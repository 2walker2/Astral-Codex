using UnityEngine;

public class EclipseCodeController2 : MonoBehaviour
{
	[SerializeField]
	private SingleLightSensor[] _codeLightSensor;
	[SerializeField]
	private RotaryDial[] _dials;
	[SerializeField]
	private AbstractDoor _frontDoor;
	[SerializeField]
	private int[] _code;
}
