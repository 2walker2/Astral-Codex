using UnityEngine;

public class Elevator : MonoBehaviour
{
	[SerializeField]
	private float _trackHeight;
	[SerializeField]
	private float _trackDepth;
	[SerializeField]
	private float _liftDuration;
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private OWAudioSource _owAudioSourceLP;
	[SerializeField]
	private OWAudioSource _owAudioSourceOneShot;
	[SerializeField]
	private OWTriggerVolume[] _killTriggers;
}
