using UnityEngine;

public class FloodToggle : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private GameObject[] _targets;
	[SerializeField]
	private OWTriggerVolume[] _volumes;
	[SerializeField]
	private bool _deactivateOnFlood;
	[SerializeField]
	private bool _toggleActiveOnAwake;
}
