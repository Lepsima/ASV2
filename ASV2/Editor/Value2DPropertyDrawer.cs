using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Lepsima.ASV {
[CustomPropertyDrawer(typeof(IAutoUnit2), true)]
public class Value2DPropertyDrawer : PropertyDrawer {

	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		PropertyField nameField = new(property.FindPropertyRelative("x"), property.displayName);
		container.Add(nameField);
		return container;
	}
}
}