using System.Collections;
using System.Collections.Generic;
using CollectiblesModule.Runtime.Interfaces;
using UnityEngine;

namespace CollectiblesModule.Runtime.Scripts
{
	[RequireComponent(typeof(Collider))]
	public class Collectible : MonoBehaviour, IPickUp
	{
		[SerializeField, CollectibleNameDropdown] private string collectibleName;
		public string GetCollectibleName => collectibleName;
		
		[SerializeField, CollectibleCategoryDropdown] private string collectibleCategory;
		public string GetCollectibleCategory => collectibleCategory;

		public bool TryPickUp()
		{
			OnPickUp();
			return true;
		}

		public void OnPickUp()
		{
			CollectiblesManager.instance.Collect(collectibleName);
		}
	}
}

