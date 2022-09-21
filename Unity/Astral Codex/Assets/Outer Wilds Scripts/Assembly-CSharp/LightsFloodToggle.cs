using UnityEngine;

public class LightsFloodToggle : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private OWLightController[] _lights;
	[SerializeField]
	private GameObject _lightsRoot;
}
