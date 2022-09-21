using UnityEngine;

public class RingRiverAudioPath : BaseRiverAudioPath
{
	[SerializeField]
	private OWRingRiverCollider _ringRiverCollider;
	[SerializeField]
	protected BaseRiverAudioPath.Triangle[] _postFloodTriangles;
	[SerializeField]
	protected float[] _cachedPostFloodTriangleSections;
}
