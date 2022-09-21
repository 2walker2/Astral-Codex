using UnityEngine;

public class GearInterfaceEffects : MonoBehaviour
{
	[SerializeField]
	private float _speed;
	[SerializeField]
	private bool _useUnscaledTime;
	[SerializeField]
	private Transform _transformOverride;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private AnimationCurve _failureAnimation;
	[SerializeField]
	private float _failureAnimMaxAngle;
	[SerializeField]
	private float _failureAnimDuration;
}
