using UnityEngine;

public class QuantumLightningObject : MonoBehaviour
{
	[SerializeField]
	private Light _light;
	[SerializeField]
	private GameObject[] _models;
	[SerializeField]
	private ParticleSystem[] _particleSystems;
	[SerializeField]
	private OWAudioSource _audioSource;
}
