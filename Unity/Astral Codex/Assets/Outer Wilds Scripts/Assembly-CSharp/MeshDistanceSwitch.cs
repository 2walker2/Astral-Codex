using UnityEngine;

public class MeshDistanceSwitch : MonoBehaviour
{
	[SerializeField]
	private DistanceTracker _tracker;
	[SerializeField]
	private float _distanceLimit;
	[SerializeField]
	private bool _switchOnWhenUnderLimit;
	[SerializeField]
	private MeshCollider _collider;
	[SerializeField]
	private MeshRenderer _renderer;
}
