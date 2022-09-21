using UnityEngine;

public class ViewAngleCloakController : MonoBehaviour
{
	[SerializeField]
	private float _viewAngle;
	[SerializeField]
	private float _viewRadius;
	[SerializeField]
	private Transform _focalPoint;
	[SerializeField]
	private DitheringAnimator _fireDitherAnimator;
	[SerializeField]
	private DitheringAnimator _structureDitherAnimator;
}
