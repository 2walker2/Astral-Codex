using UnityEngine;

public class BlackHoleVolume : VanishVolume
{
	[SerializeField]
	private SingularityController _singularityController;
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private OWAudioSource _emissionSource;
}
