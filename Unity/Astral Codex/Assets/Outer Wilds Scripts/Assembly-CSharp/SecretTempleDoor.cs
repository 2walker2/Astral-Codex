using UnityEngine;

public class SecretTempleDoor : MonoBehaviour
{
	[SerializeField]
	private AbstractGhostDoorInterface _interface;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRendererFadeController _lightBeamController;
	[SerializeField]
	private AbstractDoor _door;
	[SerializeField]
	private CageElevator _elevator;
	[SerializeField]
	private OWTriggerVolume _basementShipLogTrigger;
}
