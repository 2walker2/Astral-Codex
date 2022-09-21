using UnityEngine;

public class TimelineObliterationController : MonoBehaviour
{
	[SerializeField]
	private TimelineObliterationEffect[] _voidCrackEffectList;
	[SerializeField]
	private float _timeToCrackEffect;
	[SerializeField]
	private float _timeToScreenEffect;
	[SerializeField]
	private float _timeToParadoxDeathScreenEffect;
	[SerializeField]
	private OWAudioSource _screenShatterAudioSource;
	[SerializeField]
	private OWAudioSource _voidCrackAudioSource;
}
