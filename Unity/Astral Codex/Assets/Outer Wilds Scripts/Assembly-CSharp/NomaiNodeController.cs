using UnityEngine;

public class NomaiNodeController : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _resetSlot;
	[SerializeField]
	private NomaiInterfaceNode[] _nodes;
	[SerializeField]
	private NodeConnection[] _connections;
	[SerializeField]
	private Material _inactiveMaterial;
	[SerializeField]
	private Material _activeMaterial;
}
