using UnityEngine;

public class ShipThrusterAudio : ThrusterAudio
{
	[SerializeField]
	private OWAudioSource _ignitionSource;
	[SerializeField]
	private OWAudioSource _rightTranslationalSource;
	[SerializeField]
	private OWAudioSource _rightUnderwaterSource;
	[SerializeField]
	private OWAudioSource _leftTranslationalSource;
	[SerializeField]
	private OWAudioSource _leftUnderwaterSource;
	[SerializeField]
	private AnimationCurve _thrustToVolumeCurve;
	[SerializeField]
	private AudioLowPassFilter _rotationalSourceLowpass;
}
