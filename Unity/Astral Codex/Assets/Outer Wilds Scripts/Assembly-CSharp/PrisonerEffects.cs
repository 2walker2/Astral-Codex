using UnityEngine;

public class PrisonerEffects : GhostEffects
{
	[SerializeField]
	private Transform _tableLanternIKTarget;
	[SerializeField]
	private Transform _wallTorchIKTarget;
	[SerializeField]
	private Transform _projectVisionIKTarget;
	[SerializeField]
	private OWAudioSource _handAudioSource;
	[SerializeField]
	private OWAudioSource _foleyAudioSource;
}
