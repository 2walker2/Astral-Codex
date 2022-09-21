using UnityEngine;

public class EntitlementsManager : MonoBehaviour
{
	public enum AsyncOwnershipStatus
	{
		NotReady = 0,
		Owned = 1,
		NotOwned = 2,
	}

	[SerializeField]
	private PopupMenu _popupMenu;
	[SerializeField]
	private bool _useTestValue;
	[SerializeField]
	private AsyncOwnershipStatus _testValue;
}
