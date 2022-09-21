using UnityEngine;

public class GhostNodeMarker : MonoBehaviour
{
	public int nodeIndex;
	public GhostNodeMarker[] visibleNodes;
	public bool isPathNode;
	public bool pathStart;
	public bool pathEnd;
	public bool isPatrolNode;
	public bool isSearchNode;
	public GhostNode.NodeLayer searchLayer;
	public float searchAngle;
}
