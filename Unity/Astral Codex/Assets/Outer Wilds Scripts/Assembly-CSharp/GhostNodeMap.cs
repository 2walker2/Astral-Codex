using UnityEngine;
using System.Collections.Generic;

public class GhostNodeMap : MonoBehaviour
{
	[SerializeField]
	private List<GhostMarkerEdge> _markerEdges;
	[SerializeField]
	private Shape _mapBounds;
}
