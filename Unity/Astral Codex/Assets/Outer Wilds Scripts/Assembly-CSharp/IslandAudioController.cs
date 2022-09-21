using UnityEngine;

public class IslandAudioController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWAudioSource _islandAudioSource;
	[SerializeField]
	private GameObject _shoreAudioRoot;
	[SerializeField]
	private AudioVolume[] _audioVolumes;
}
