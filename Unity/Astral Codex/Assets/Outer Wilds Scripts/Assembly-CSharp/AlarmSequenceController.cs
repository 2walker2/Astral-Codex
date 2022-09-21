using UnityEngine;

public class AlarmSequenceController : MonoBehaviour
{
	[SerializeField]
	private float _wakeDuration;
	[SerializeField]
	private float _recoveryDuration;
	[SerializeField]
	private float _audioLingerTime;
	[SerializeField]
	private AnimationCurve _volumeCurve;
	[SerializeField]
	private float _pulseAttackLength;
	[SerializeField]
	private float _pulseHoldLength;
	[SerializeField]
	private float _pulseCooldownLength;
}
