using UnityEngine;

public class FloodImpactEffect : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private ParticleSystem _particleSystem;
	[SerializeField]
	private AudioType _audioType;
	[SerializeField]
	private float _delay;
}
