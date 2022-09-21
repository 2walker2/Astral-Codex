using UnityEngine;

public class EclipseCodeController3 : SectoredMonoBehaviour
{
	[SerializeField]
	private MultiInteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearInterface;
	[SerializeField]
	private RotaryDial[] _dials;
	[SerializeField]
	private SingleLightSensor _lightSensor;
	[SerializeField]
	private Transform _lightSensorRoot;
	[SerializeField]
	private int[] _code;
	[SerializeField]
	private AbstractDoor _frontDoor;
}
