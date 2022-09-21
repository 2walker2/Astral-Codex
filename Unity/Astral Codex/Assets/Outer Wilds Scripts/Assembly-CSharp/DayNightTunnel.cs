using UnityEngine;

public class DayNightTunnel : MonoBehaviour
{
	[SerializeField]
	private Transform _vehicleRoot;
	[SerializeField]
	private Transform _platform;
	[SerializeField]
	private Transform _dayShell;
	[SerializeField]
	private Transform _nightShell;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private LightCodeInterpreter _lightCodeInterpreter;
	[SerializeField]
	private float _height;
}
