using UnityEngine;

public class AirlockInterfaceOld : AbstractGhostAirlockInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensorClockwise;
	[SerializeField]
	private SingleLightSensor[] _lightSensorCounterClock;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private AbstractGhostDoorInterface _frontInterface;
	[SerializeField]
	private AbstractGhostDoorInterface _backInterface;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _maxRotation;
	[SerializeField]
	private float _slowDownSpeed;
	[SerializeField]
	private float _litUpSlowDownSpeed;
}
