using UnityEngine;

public class RaftMusicController : MonoBehaviour
{
	[SerializeField]
	private RingWorldController _ringWorldController;
	[SerializeField]
	private OWRingRiverCollider _riverCollider;
	[SerializeField]
	private OWAudioSource _riverSource;
	[SerializeField]
	private OWAudioSource _calmSource;
	[SerializeField]
	private OWTriggerVolume[] _muteVolumes;
	[SerializeField]
	private float _startReservoirDegrees;
}
