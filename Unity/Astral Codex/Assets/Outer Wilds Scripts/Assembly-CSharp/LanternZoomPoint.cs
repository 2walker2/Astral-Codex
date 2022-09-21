using UnityEngine;

public class LanternZoomPoint : SectoredMonoBehaviour
{
	[SerializeField]
	private float _arrivalDistance;
	[SerializeField]
	private float _minActivationDistance;
	[SerializeField]
	private AnimationCurve _zoomInCurve;
	[SerializeField]
	private AnimationCurve _retroZoomCurve;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private Animator _totemAnimator;
}
