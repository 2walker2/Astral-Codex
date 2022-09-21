using UnityEngine;

public class RotateToPoint : MonoBehaviour
{
	[SerializeField]
	private float _timeToMaxSpeed;
	[SerializeField]
	private float _targetLockAngle;
	[SerializeField]
	protected bool _quaternionTargetMode;
	[SerializeField]
	protected bool _setLocalRotationInQuatTargetMode;
	[SerializeField]
	private AnimationCurve _rampUpCurve;
}
