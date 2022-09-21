using UnityEngine;

public class GhostIK : SectoredMonoBehaviour
{
	[SerializeField]
	private OWIK _leftFootIK;
	[SerializeField]
	private OWIK _rightFootIK;
	[SerializeField]
	private bool _adjustHipsY;
	[SerializeField]
	private float _hipsLerp;
	[SerializeField]
	private float _maxFootVerticalDistance;
	[SerializeField]
	private float _footYOffset;
	[SerializeField]
	private Transform _leftToe;
	[SerializeField]
	private Transform _rightToe;
}
