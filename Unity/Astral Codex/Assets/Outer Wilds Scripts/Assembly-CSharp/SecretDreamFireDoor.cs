using UnityEngine;

public class SecretDreamFireDoor : MonoBehaviour
{
	[SerializeField]
	private SlidingDoor _door;
	[SerializeField]
	private int _secretIndex;
	[SerializeField]
	private LightSensor[] _lightSensors;
	[SerializeField]
	private OWLightController[] _lightControllers;
	[SerializeField]
	private InteractReceiver _interactReceiver;
}
