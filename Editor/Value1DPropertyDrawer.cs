using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Lepsima.ASV {
[CustomPropertyDrawer(typeof(IAutoUnit), true)]
public class Value1DPropertyDrawer : PropertyDrawer {

	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		PropertyField nameField = new(property.FindPropertyRelative("_value"), property.displayName);
		container.Add(nameField);
		return container;
	}
}
}