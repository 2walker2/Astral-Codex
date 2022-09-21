using UnityEngine;

public class LightDarkDoorController : MonoBehaviour
{
	[SerializeField]
	private bool _openInDarkness;
	[SerializeField]
	private bool _stayOpen;
	[SerializeField]
	private SlidingDoor _door;
	[SerializeField]
	private LightSensor _lightSensor;
}
