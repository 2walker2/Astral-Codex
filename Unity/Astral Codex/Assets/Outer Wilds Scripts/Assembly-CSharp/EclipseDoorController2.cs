using UnityEngine;

public class EclipseDoorController2 : MonoBehaviour
{
	[SerializeField]
	private SingleLightSensor _frontLightSensor;
	[SerializeField]
	private SingleLightSensor _backLightSensor;
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
	private float _anglePrecision;
}
