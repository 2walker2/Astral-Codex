using UnityEngine;

public class ProxyGhostController : SectoredMonoBehaviour
{
	public enum IdleStyle
	{
		Normal = 0,
		Hunched = 1,
		Twitchy = 2,
		HoldInstrument = 3,
		SkyGaze = 4,
		ShoeGaze = 5,
		Lean = 6,
	}

	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private IdleStyle _idleStyle;
	[SerializeField]
	private GhostEffects.DeathAnimStyle _deathStyle;
	[SerializeField]
	private OWAudioSource _voiceAudioSource;
	[SerializeField]
	private OWRenderer[] _renderers;
	[SerializeField]
	private ParticleSystem _deathParticleSystem;
	[SerializeField]
	private bool _rightHandIK;
	[SerializeField]
	private Transform _rightHandIKTarget;
	[SerializeField]
	private bool _leftHandIK;
	[SerializeField]
	private Transform _leftHandIKTarget;
	[SerializeField]
	private bool _rightFootIK;
	[SerializeField]
	private Transform _rightFootIKTarget;
	[SerializeField]
	private bool _leftFootIK;
	[SerializeField]
	private Transform _leftFootIKTarget;
	[SerializeField]
	private bool _headLook;
	[SerializeField]
	private OWTriggerVolume _headLookTriggerVolume;
}
