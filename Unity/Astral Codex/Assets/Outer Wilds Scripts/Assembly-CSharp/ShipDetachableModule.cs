using UnityEngine;

public class ShipDetachableModule : ShipModule
{
	[SerializeField]
	private float _mass;
	[SerializeField]
	private Vector3 _localCenterOfMass;
	[SerializeField]
	private Vector3 _detectorCenter;
	[SerializeField]
	private float _detectorRadius;
	[SerializeField]
	private GameObject _impactAudioPrefab;
	[SerializeField]
	private ShipLODTrigger _moduleLODTrigger;
}
