using UnityEngine;

public class HUDHelmetAnimator : MonoBehaviour
{
	[SerializeField]
	private Transform _helmetRoot;
	[SerializeField]
	private GameObject _helmetVisuals;
	[SerializeField]
	private MeshRenderer _hudRenderer;
	[SerializeField]
	private float _helmetMoveSpeed;
	[SerializeField]
	private DampedSpring3D _helmetOffsetSpring;
	[SerializeField]
	private float _jumpImpulse;
	[SerializeField]
	private float _impactImpulseScale;
	[SerializeField]
	private Vector3 _jetpackAccelScale;
	[SerializeField]
	private Vector3 _boosterShudderFrequency;
	[SerializeField]
	private Vector3 _boosterShudderScale;
	[SerializeField]
	private Vector3 _offsetMaxRanges;
	[SerializeField]
	private DampedSpringRadial3D _helmetTwistSpring;
	[SerializeField]
	private Vector2 _lookTwistSensitivity;
	[SerializeField]
	private Vector3 _twistMaxRanges;
	[SerializeField]
	private float _hudFlickerOnLength;
	[SerializeField]
	private float _hudFlickerOutLength;
	[SerializeField]
	private float _hudCalibrationLength;
	[SerializeField]
	private float _hudCrashLength;
	[SerializeField]
	private float _hudRebootLength;
	[SerializeField]
	private DampedSpring _hudDamageWobbleSpring;
	[SerializeField]
	private float _hudDamageWobbleScale;
	[SerializeField]
	private float _hudDamageFlickerScale;
	[SerializeField]
	private ElectricalArc[] _electricalArcs;
	[SerializeField]
	private float _electricalArcRadius;
	[SerializeField]
	private float _hudConversationFadeLength;
}
