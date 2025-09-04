using System.Collections;
using System.Collections.Generic;
using CollectiblesModule.Runtime.ScriptableObjects;
using CollectiblesModule.Runtime.Scripts;
using UnityEditor;
using UnityEngine;

namespace CollectiblesModule.Editor
{
	[CustomPropertyDrawer(typeof(CollectibleCategoryDropdownAttribute))]
	public class CollectibleCategoryDropdownDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			CollectiblesBaseData bd = Resources.Load<CollectiblesBaseData>("CollectiblesBaseData/CollectiblesBaseData");
			if (bd == null)
			{
				Debug.LogError("A scriptable object named CollectiblesBaseData must exist in resources/CollectibleBaseData");
				return;
			}
			string[] options = bd.collectibleCategories;

			// Find current index
			int index = Mathf.Max(0, System.Array.IndexOf(options, property.stringValue));

			// Draw popup
			int newIndex = EditorGUI.Popup(position, label.text, index, options);

			// Assign back chosen value
			property.stringValue = options[newIndex];
		}
	}
}


