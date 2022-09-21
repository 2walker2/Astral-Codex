using UnityEngine;

public class MapController : MonoBehaviour
{
	[SerializeField]
	private bool _isTrailerMap;
	[SerializeField]
	private MapMarkerManager _mapMarkerManager;
	[SerializeField]
	private float _panSpeed;
	[SerializeField]
	private float _maxPanDistance;
	[SerializeField]
	private float _yawSpeed;
	[SerializeField]
	private float _defaultYawAngle;
	[SerializeField]
	private float _pitchSpeed;
	[SerializeField]
	private float _minPitchAngle;
	[SerializeField]
	private float _maxPitchAngle;
	[SerializeField]
	private float _defaultPitchAngle;
	[SerializeField]
	private float _zoomSpeed;
	[SerializeField]
	private float _minZoomDistance;
	[SerializeField]
	private float _maxZoomDistance;
	[SerializeField]
	private float _defaultZoomDist;
	[SerializeField]
	private AnimationCurve _revealCurve;
	[SerializeField]
	private float _initialPitchAngle;
	[SerializeField]
	private float _initialZoomDist;
	[SerializeField]
	private float _observatoryRevealDist;
	[SerializeField]
	private float _observatoryRevealTwist;
	[SerializeField]
	private float _defaultRevealLength;
	[SerializeField]
	private float _observatoryRevealLength;
	[SerializeField]
	private float _observatoryInteractDelay;
	[SerializeField]
	private float _lockOnMoveLength;
	[SerializeField]
	private float _playerFramingScale;
	[SerializeField]
	private float _verticalResetLength;
	[SerializeField]
	private MeshRenderer _gridRenderer;
	[SerializeField]
	private Color _gridColor;
	[SerializeField]
	private float _gridSize;
	[SerializeField]
	private float _gridLockOnLength;
	[SerializeField]
	private OWAudioSource _audioSource;
}
