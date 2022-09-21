using UnityEngine;

public class AnimOneShotEffectController : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private AudioType _audioClip;
	[SerializeField]
	private float _randomPitchRange;
	[SerializeField]
	private ParticleSystem _particles;
}
