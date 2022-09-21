using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
	[SerializeField]
	private Collider _bodyCollider;
	[SerializeField]
	private Collider _antiSinkingCollider;
	[SerializeField]
	private float _runSpeed;
	[SerializeField]
	private float _walkSpeed;
	[SerializeField]
	private float _strafeSpeed;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _airSpeed;
	[SerializeField]
	private float _airAcceleration;
	[SerializeField]
	private float _minJumpSpeed;
	[SerializeField]
	private float _maxJumpSpeed;
	[SerializeField]
	private bool _useChargeJump;
	[SerializeField]
	private bool _useChargeCurve;
	[SerializeField]
	private AnimationCurve _jumpChargeCurve;
	[SerializeField]
	private float _minStaggerDamage;
	[SerializeField]
	private float _minStaggerLength;
	[SerializeField]
	private float _maxStaggerLength;
	[SerializeField]
	private float _tumbleThreshold;
	[SerializeField]
	private float _tumbleDuration;
	[SerializeField]
	private int _maxAngleToBeGrounded;
	[SerializeField]
	private int _maxAngleBetweenSlopes;
	[SerializeField]
	private bool _groundSnappingEnabled;
	[SerializeField]
	private float _jumpDurationAfterUngrounded;
}
