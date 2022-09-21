using UnityEngine;

public class SingularityController : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _creationCurve;
	[SerializeField]
	private AnimationCurve _destructionCurve;
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private bool _muteSingularityEffectAudio;
	[SerializeField]
	private OWAudioSource _owAmbientSource;
	[SerializeField]
	private OWAudioSource _owOneShotSource;
}
