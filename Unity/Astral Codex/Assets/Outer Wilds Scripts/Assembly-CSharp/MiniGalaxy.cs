using UnityEngine;

public class MiniGalaxy : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _deathParticles;
	[SerializeField]
	private ParticleSystem[] _galaxySpiralParticles;
	[SerializeField]
	private Renderer[] _galaxyRenderers;
	[SerializeField]
	private OWLight2 _light;
	[SerializeField]
	private OWTriggerVolume _trigger;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private bool _randomRotation;
	[SerializeField]
	private float _expandedLightRange;
}
