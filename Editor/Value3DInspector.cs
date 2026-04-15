using UnityEditor;
using UnityEngine;

namespace Lepsima.ASV {
[CustomPropertyDrawer(typeof(IAutoUnitUI3), true)]
public class Value3DInspector : PropertyDrawer {
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		EditorGUI.BeginProperty(position, label, property);
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

		int indent = EditorGUI.indentLevel;
		EditorGUI.indentLevel = 0;

		(Rect left, Rect right) = SplitRect(position, 0.8f);
		Vector3Property(right, property);
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

	private static void Vector3Property(Rect rect, SerializedProperty property) {
		SerializedProperty valueProp = property.FindPropertyRelative("_value");
		Vector3 v = valueProp.vector3Value;
		float[] values = { v.x, v.y, v.z };

		GUIContent[] labels = { GUIContent.none, GUIContent.none, GUIContent.none };
		EditorGUI.MultiFloatField(rect, GUIContent.none, labels, values);
		valueProp.vector3Value = new Vector3(values[0], values[1], values[2]);
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
		return EditorGUIUtility.singleLineHeight;
	}
}
}