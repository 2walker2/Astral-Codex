using UnityEngine;

public class AudioLoopCrossfader : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotAudioStart;
	[SerializeField]
	private OWAudioSource _oneShotAudioEnd;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private AudioType _startClip;
	[SerializeField]
	private AudioType _endClip;
	[SerializeField]
	private float _loopFadeInDuration;
	[SerializeField]
	private float _loopFadeOutDuration;
	[SerializeField]
	private float _cancelFadeDuration;
}
