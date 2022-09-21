using UnityEngine;

public class GhostController : MonoBehaviour
{
	[SerializeField]
	private GhostNodeMap _nodeMap;
	[SerializeField]
	private CapsuleCollider _ghostCollider;
	[SerializeField]
	private DreamLanternController _lantern;
	[SerializeField]
	private GhostGrabController _grabController;
	[SerializeField]
	private Transform _lanternCarrySocket;
}
