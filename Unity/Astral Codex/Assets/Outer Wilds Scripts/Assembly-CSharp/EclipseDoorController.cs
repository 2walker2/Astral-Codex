using UnityEngine;

public class EclipseDoorController : AbstractGhostDoorInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private AbstractDoor[] _backDoors;
	[SerializeField]
	private AbstractDoor _frontDoor;
	[SerializeField]
	private float _rotationSpeed;
	[SerializeField]
	private float _startingRotation;
	[SerializeField]
	private float _angleAccuracy;
	[SerializeField]
	private bool _disableSensorsWhileOpen;
	[SerializeField]
	private bool _canRotateWhileOpen;
	[SerializeField]
	private float _timeToClosure;
	[SerializeField]
	private OWAudioSource _rotationAudio;
}
