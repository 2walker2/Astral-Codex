using UnityEngine;

public class ImpactAudioPool : MonoBehaviour
{
	[SerializeField]
	private AudioType _clipType;
	[SerializeField]
	private float _minMass;
	[SerializeField]
	private float _minSpeed;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private OWAudioSource[] _audioSources;
}
