using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollectiblesModule.Runtime.Interfaces
{
	public interface IPickUp
	{
		public bool TryPickUp();
		public void OnPickUp();
	}
}


