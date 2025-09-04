using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollectiblesModule.Runtime.ScriptableObjects
{
	[CreateAssetMenu(fileName = "BaseData", menuName = "ScriptableObjects/CollectiblesBaseData", order = 1)]
	public class CollectiblesBaseData : ScriptableObject
	{
		public string[] collectibleNames;
		public string[] collectibleCategories;
	}
}

