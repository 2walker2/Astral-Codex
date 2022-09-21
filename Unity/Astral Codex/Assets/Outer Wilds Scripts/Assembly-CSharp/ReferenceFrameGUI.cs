using UnityEngine;

public class ReferenceFrameGUI : MonoBehaviour
{
	private enum ReferenceFrameGUIType
	{
		PLAYER = 0,
		SHIP = 1,
		LANDING_CAM = 2,
		MAP = 3,
	}

	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Canvas _referenceCanvas;
	[SerializeField]
	private OWRigidbody _activeBody;
	[SerializeField]
	private OWCamera _activeCam;
	[SerializeField]
	private LockOnReticule _reticule1;
	[SerializeField]
	private LockOnReticule _reticule2;
	[SerializeField]
	private Color _departingColor;
	[SerializeField]
	private Color _approachingColor;
	[SerializeField]
	private Color _staticColor;
	[SerializeField]
	private float _possLockReticuleAlpha;
	[SerializeField]
	private OffScreenIndicator _offScreenIndicator;
	[SerializeField]
	private ReferenceFrameGUIType _type;
}
