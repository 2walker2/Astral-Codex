using UnityEngine;
using UnityEngine.UI;

public class PostCreditsManager : MonoBehaviour
{
	[SerializeField]
	private OWCamera _camera;
	[SerializeField]
	private float _fadeInTime;
	[SerializeField]
	private float _fadeOutTime;
	[SerializeField]
	private GameObject[] _solanumObjects;
	[SerializeField]
	private OWAudioSource _campfireAudio;
	[SerializeField]
	private OWAudioSource _campfireOneShot;
	[SerializeField]
	private OWLightController _campfireLightController;
	[SerializeField]
	private Light _campfirePrimaryLight;
	[SerializeField]
	private Renderer _campfireFlamesRenderer;
	[SerializeField]
	private Renderer _campfireSmokeRenderer;
	[SerializeField]
	private Image[] _campfireLitImages;
	[SerializeField]
	private GameObject[] _prisonerObjects;
	[SerializeField]
	private OWAudioSource _ruinsOneShot;
	[SerializeField]
	private AnimationCurve _ruinsLightCurve;
	[SerializeField]
	private Image[] _ruinsLitImages;
	[SerializeField]
	private OWAudioSource _lanternOneShot;
	[SerializeField]
	private AnimationCurve _lanternLightCurve;
	[SerializeField]
	private Image[] _lanternLitImages;
	[SerializeField]
	private GameObject[] _probeObjects;
	[SerializeField]
	private Animator _probeAnimator;
	[SerializeField]
	private OWAudioSource _probeAudio;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _ambientSource;
}
