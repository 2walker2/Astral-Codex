using UnityEngine;

public class GhostSequenceAudioVolume : AudioVolume
{
	[SerializeField]
	private OWAudioSource _reducedFrightsAudio;
	[SerializeField]
	private OWAudioSource _suspenseAudio;
	[SerializeField]
	private OWAudioSource _dreadAudio;
	[SerializeField]
	private OWAudioSource _fearAudio;
	[SerializeField]
	private OWAudioSource _slamAudio;
	[SerializeField]
	private GhostBrain[] _ghosts;
}
