using System;
using UnityEngine;

[Serializable]
public struct RiverMarkerGroup
{
	public RiverMarkerGroup(RiverFlowMarker[] markers, Transform riverTransform, OWRingRiverCollider riverCollider) : this()
	{
	}

	public Vector3[] localPositions;
	public Vector3[] localRightDirs;
	public float[] magnitudes;
	public float[] degrees;
}
