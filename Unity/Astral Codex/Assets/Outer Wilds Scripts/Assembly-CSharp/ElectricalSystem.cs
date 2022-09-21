using UnityEngine;

public class ElectricalSystem : MonoBehaviour
{
	[SerializeField]
	private ElectricalSystem[] _connectedSystems;
	[SerializeField]
	private ElectricalComponent[] _connectedComponents;
	[SerializeField]
	private float _systemDelay;
}
