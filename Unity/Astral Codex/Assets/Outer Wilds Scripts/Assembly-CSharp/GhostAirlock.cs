using UnityEngine;

public class GhostAirlock : MonoBehaviour
{
	[SerializeField]
	private AirlockInterface _interface;
	[SerializeField]
	private bool _startOpen;
	[SerializeField]
	private RotatingDoor _innerDoor;
	[SerializeField]
	private RotatingDoor _outerDoor;
	[SerializeField]
	private OWTriggerVolume _atmosphereVolume;
	[SerializeField]
	private OWTriggerVolume _airlockVolume;
	[SerializeField]
	private OWTriggerVolume _interiorSectorVolume;
	[SerializeField]
	private AudioLoopCrossfader _lightSensorCrossfader;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _innerOneShotAudio;
	[SerializeField]
	private OWAudioSource _outerOneShotAudio;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
}
