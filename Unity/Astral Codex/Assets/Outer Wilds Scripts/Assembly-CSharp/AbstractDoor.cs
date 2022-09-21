using UnityEngine;

public class AbstractDoor : MonoBehaviour
{
	[SerializeField]
	private AbstractGhostDoorInterface _interface;
	[SerializeField]
	protected bool _startOpen;
}
