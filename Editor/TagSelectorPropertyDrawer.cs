using BrainDrops.Unolith.Attributes;
using UnityEditor;
using UnityEngine;

namespace BrainDrops.Unolith.Editor
{
    [CustomPropertyDrawer(typeof(TagSelectorAttribute))]
    public class TagSelectorPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var oldTag = property.stringValue;
            var newTag = EditorGUI.TagField(position, label, oldTag);

            if (newTag != oldTag)
            {
                property.stringValue = newTag;
            }
        }
    }
}
