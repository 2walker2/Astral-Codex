using UnityEngine;

public class HauntedEntrance : MonoBehaviour
{
	[SerializeField]
	private EntrywayTrigger _trigger;
	[SerializeField]
	public LightCodeDoor door;
	[SerializeField]
	protected HauntedRoom _roomEntered;
}
