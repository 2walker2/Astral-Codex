using UnityEngine;

public class EclipseElevatorController : AbstractGhostElevatorInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private float _rotationSpeed;
	[SerializeField]
	private float _anglePrecision;
	[SerializeField]
	private AudioLoopCrossfader _lightSensorCrossfader;
	[SerializeField]
	private OWAudioSource _rotationAudio;
}
