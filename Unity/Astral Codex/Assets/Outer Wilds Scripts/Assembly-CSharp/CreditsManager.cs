using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
	[SerializeField]
	private bool _finalCredits;
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[SerializeField]
	private AnimationCurve _fadeFromWhiteCurve;
	[SerializeField]
	private Image _fadeImage;
	[SerializeField]
	private float _fadeLength;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private OWAudioSource _kazooSource;
}
