using UnityEngine;

public class RepairReceiver : MonoBehaviour
{
	public enum Type
	{
		ShipComponent = 0,
		ShipHull = 1,
		SatelliteNode = 2,
	}

	[SerializeField]
	private Type _type;
	[SerializeField]
	private ShipComponent _targetComponent;
	[SerializeField]
	private ShipHull _targetHull;
	[SerializeField]
	private SatelliteNode _targetSatNode;
	[SerializeField]
	private float _repairDistance;
}
