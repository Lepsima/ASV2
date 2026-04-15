using UnityEditor;
using UnityEngine;

namespace Lepsima.ASV {
[CustomPropertyDrawer(typeof(IAutoUnitUI), true)]
public class Value1DInspector : PropertyDrawer {
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		EditorGUI.BeginProperty(position, label, property);
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

		int indent = EditorGUI.indentLevel;
		EditorGUI.indentLevel = 0;

		(Rect left, Rect right) = SplitRect(position, 0.8f);
		FloatProperty(right, property);
		EnumProperty(left, property);

		EditorGUI.indentLevel = indent;
		EditorGUI.EndProperty();
	}

	private static (Rect, Rect) SplitRect(Rect position, float ratio) {
		float leftWidth = position.width * (1f - ratio);
		float rightWidth = position.width * ratio;

		Rect left = new(position.x, position.y, leftWidth - 2, position.height);
		Rect right = new(position.x + leftWidth + 2, position.y, rightWidth - 2, position.height);

		return (left, right);
	}

	private static void EnumProperty(Rect rect, SerializedProperty property) {
		SerializedProperty prop = property.FindPropertyRelative("type");
		EditorGUI.PropertyField(rect, prop, GUIContent.none);
	}

	private static void FloatProperty(Rect rect, SerializedProperty property) {
		SerializedProperty prop = property.FindPropertyRelative("_value");
		EditorGUI.PropertyField(rect, prop, GUIContent.none);
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
		return EditorGUIUtility.singleLineHeight;
	}
}
}