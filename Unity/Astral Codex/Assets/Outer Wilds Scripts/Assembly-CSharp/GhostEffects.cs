using UnityEngine;

public class GhostEffects : MonoBehaviour
{
	public enum DeathAnimStyle
	{
		Random = -1,
		Reaching = 0,
		Reaching_Jittery = 1,
		Crunchy = 2,
		DramaClub = 3,
	}

	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private DeathAnimStyle _deathAnimStyle;
	[SerializeField]
	private bool _ignoreSleepAnimation;
	[SerializeField]
	private OWAudioSource _lanternAudioSource;
	[SerializeField]
	private OWAudioSource _voiceAudioSourceNear;
	[SerializeField]
	private OWAudioSource _voiceAudioSourceFar;
	[SerializeField]
	private OWAudioSource _feetAudioSourceNear;
	[SerializeField]
	private OWAudioSource _feetAudioSourceFar;
	[SerializeField]
	private OWRenderer[] _renderers;
	[SerializeField]
	private OWEmissiveRenderer[] _eyeRenderers;
	[SerializeField]
	private ParticleSystem _deathParticleSystem;
	[SerializeField]
	private GhostIK _ghostIKController;
	[SerializeField]
	private Transform _ikTargetHoldingLantern;
	[SerializeField]
	private Transform _ikHintHoldingLantern;
}
