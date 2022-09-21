using UnityEngine;

public class QuantumSkeletonTower : QuantumObject
{
	[SerializeField]
	private GameObject[] _towerSkeletons;
	[SerializeField]
	private GameObject[] _towerTrackerObjects;
	[SerializeField]
	private VisibilityObject[] _pointingSkeletons;
	[SerializeField]
	private EyeShuttleController _shuttleController;
	[SerializeField]
	private float _minPlayerOffset;
	[SerializeField]
	private float _maxPlayerOffset;
	[SerializeField]
	private bool _drawOffsets;
}
