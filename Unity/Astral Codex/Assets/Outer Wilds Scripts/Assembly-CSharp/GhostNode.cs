using UnityEngine;
using System.Collections.Generic;

public class GhostNode
{
	public enum NodeLayer
	{
		Red = 1,
		Yellow = 2,
		Blue = 4,
		Orange = 8,
		Green = 16,
		Purple = 32,
	}

	public GhostNode(int index, GhostNodeMarker marker)
	{
	}

	public string name;
	public int index;
	public Vector3 localPosition;
	public Vector3 localForward;
	public List<GhostNode> neighbors;
	public List<int> visibleNodes;
	public float lastClearTime;
}
