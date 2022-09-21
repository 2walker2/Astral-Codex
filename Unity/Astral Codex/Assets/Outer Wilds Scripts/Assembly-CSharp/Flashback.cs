using UnityEngine;

public class Flashback : MonoBehaviour
{
	[SerializeField]
	private float _screenStartDist;
	[SerializeField]
	private float _screenEndDist;
	[SerializeField]
	private float _playbackDelay;
	[SerializeField]
	private float _maskStartDist;
	[SerializeField]
	private float _maskEndDist;
	[SerializeField]
	private float _maskAnimDuration;
	[SerializeField]
	private float _lightFadeDuration;
	[SerializeField]
	private float _dataStreamDelay;
	[SerializeField]
	private float _dataStreamRevealDuration;
	[SerializeField]
	private float _reverseScreenStartDist;
	[SerializeField]
	private float _reverseScreenEndDist;
	[SerializeField]
	private float _reverseStreamRevealDuration;
	[SerializeField]
	private float _reversePlaybackDelay;
	[SerializeField]
	private float _reversePlaybackDuration;
	[SerializeField]
	private float _reverseScreenShrinkDuration;
	[SerializeField]
	private FlashbackAudioController _audioController;
	[SerializeField]
	private Transform _screenTransform;
	[SerializeField]
	private Transform _maskTransform;
	[SerializeField]
	private GameObject _forwardStreams;
	[SerializeField]
	private GameObject _reverseStreams;
	[SerializeField]
	private CanvasGroupAnimator _whiteFadeAnimator;
	[SerializeField]
	private AnimationCurve _whiteFadeCurve;
}
