using UnityEngine;

public class ModifyCollidersInChildren : MonoBehaviour
{
	private enum ColliderOperation
	{
		disableAll = 0,
		meshToSphereColliders = 1,
		makeTriggers = 2,
	}

	[SerializeField]
	private ColliderOperation _colliderOperation;
}
