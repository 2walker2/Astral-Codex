using UnityEngine;

public class DreamLibraryFlame : MonoBehaviour
{
	[SerializeField]
	private OWFlameController _flame;
	[SerializeField]
	private ParticleSystem[] _particles;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private HazardVolume _hazardVolume;
}
