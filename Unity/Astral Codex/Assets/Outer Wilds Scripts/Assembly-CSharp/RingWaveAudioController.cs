using UnityEngine;

public class RingWaveAudioController : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private Transform _railPointsRoot;
	[SerializeField]
	private float _startFadeOutDegrees;
	[SerializeField]
	private float _fadeOutDuration;
}
