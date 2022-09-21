using UnityEngine;

public class TitleScreenAnimation : MonoBehaviour
{
	[SerializeField]
	private OWCamera _camera;
	[SerializeField]
	private Campfire _campfire;
	[SerializeField]
	private OWLightController _ambientLightController;
	[SerializeField]
	private OWAudioSource _ambienceSource;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private CanvasGroupFadeController _gamepadSplashController;
	[SerializeField]
	private AnimationCurve _gamepadSplashCurve;
}
