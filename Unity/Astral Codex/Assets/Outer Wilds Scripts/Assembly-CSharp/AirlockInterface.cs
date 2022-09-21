using UnityEngine;

public class AirlockInterface : AbstractGhostAirlockInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private InteractReceiver _frontInterface;
	[SerializeField]
	private GearInterfaceEffects _frontGearEffects;
	[SerializeField]
	private InteractReceiver _backInterface;
	[SerializeField]
	private GearInterfaceEffects _backGearEffects;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _deceleration;
	[SerializeField]
	private float _angleAccuracy;
}
