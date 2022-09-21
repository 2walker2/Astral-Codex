using UnityEngine;

public class RiverHazardToggle : SectoredMonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private bool _activePostFlood;
	[SerializeField]
	private OWTriggerVolume[] _triggerVolumes;
	[SerializeField]
	private OWAudioSource[] _audioSources;
	[SerializeField]
	private ParticleSystem[] _particles;
	[SerializeField]
	private GameObject[] _gameObjects;
	[SerializeField]
	private PowerCableAudioController _powerCableAudio;
	[SerializeField]
	private Sector _particleSectorOverride;
}
