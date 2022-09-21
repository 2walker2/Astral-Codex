using UnityEngine;

public class AudioRail : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _audioTransform;
	[SerializeField]
	private Transform _railPointsRoot;
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private Vector3[] _railPoints;
	[SerializeField]
	private LineSegmentDistanceTracker[] _lineSegments;
}
