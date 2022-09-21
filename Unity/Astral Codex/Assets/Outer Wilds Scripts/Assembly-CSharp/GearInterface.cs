using UnityEngine;

public class GearInterface : AbstractGhostDoorInterface
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearEffects;
}
