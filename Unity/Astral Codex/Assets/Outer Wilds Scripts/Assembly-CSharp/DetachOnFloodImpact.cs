using UnityEngine;

public class DetachOnFloodImpact : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private DetachableBuilding _detachableBuilding;
	[SerializeField]
	private GameObject _detectorGameObject;
	[SerializeField]
	private Collider[] _preDetachColliders;
	[SerializeField]
	private Collider[] _postDetachColliders;
	[SerializeField]
	private SectorCullGroup _cullGroup;
	[SerializeField]
	private Sector _newCullSector;
	[SerializeField]
	private SectorCollisionGroup _collisionGroup;
	[SerializeField]
	private Sector _newCollisionSector;
}
