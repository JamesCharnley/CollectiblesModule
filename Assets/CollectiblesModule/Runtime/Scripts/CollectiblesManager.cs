using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace CollectiblesModule.Runtime.Scripts
{
	[System.Serializable]
	public struct FCollectible
	{
		[CollectibleNameDropdown]
		public string name;
		[CollectibleCategoryDropdown]
		public string category;
		public bool isCollected;
	}
	public class CollectiblesManager : MonoBehaviour
	{
		public static CollectiblesManager instance;

		[SerializeField] private FCollectible[] collectibles;
		// Start is called before the first frame update
		void Start()
		{
			if (instance != null)
			{
				Destroy(this);
			}
			instance = this;
		}

		public void Collect(string _name)
		{
			int count = 0;
			foreach (FCollectible collectible in collectibles)
			{
				if (collectible.name != _name)
				{
					count++;
					continue;
				}
				FCollectible updatedCollectible = collectible;
				updatedCollectible.isCollected = true;
				collectibles[count] = updatedCollectible;
				count++;
			}
		}
	}
}


