using UnityEngine;

public class LanternGrapplePoint2 : MonoBehaviour
{
	[SerializeField]
	private float _arrivalDistance;
	[SerializeField]
	private float _arrivalHeight;
	[SerializeField]
	private TransformAnimator _animator;
	[SerializeField]
	private AnimationCurve _speedCurve;
	[SerializeField]
	private AnimationCurve _fovCurve;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
}
