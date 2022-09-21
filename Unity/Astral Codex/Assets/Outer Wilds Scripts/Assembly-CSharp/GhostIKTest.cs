using UnityEngine;

public class GhostIKTest : MonoBehaviour
{
	[SerializeField]
	private OWIK _leftFootIK;
	[SerializeField]
	private OWIK _rightFootIK;
	[SerializeField]
	private Vector3 _feetPlacementOffset;
	[SerializeField]
	private float _footIKDampening;
	[SerializeField]
	private float _maxFootVerticalDistance;
	[SerializeField]
	private float strideLength;
	[SerializeField]
	private float _strideArcHeight;
	[SerializeField]
	private bool _adjustRootY;
	[SerializeField]
	private Transform _worldRef;
	[SerializeField]
	private Transform _torsoGoalPivot;
}
