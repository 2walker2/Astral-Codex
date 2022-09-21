using UnityEngine;

public class BridgeCollapseController : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private GameObject[] _intactObjectRoots;
	[SerializeField]
	private GameObject[] _destroyedObjectRoots;
	[SerializeField]
	private OWRigidbody[] _fragments;
	[SerializeField]
	private float _delay;
}
