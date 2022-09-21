using UnityEngine;

public class GeyserAudioController : SectoredMonoBehaviour
{
	[SerializeField]
	private Sector _exclusionSector;
	[SerializeField]
	private OWAudioSource _audioSourceLoop;
	[SerializeField]
	private OWAudioSource _audioSourceOneShot;
	[SerializeField]
	private float _geyserOpeningHeight;
	[SerializeField]
	private ParticleSystem _geyserSpoutParticles;
}
