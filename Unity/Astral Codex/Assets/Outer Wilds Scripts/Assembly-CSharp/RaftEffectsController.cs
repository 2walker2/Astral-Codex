using UnityEngine;

public class RaftEffectsController : MonoBehaviour
{
	[SerializeField]
	private RaftController _raftController;
	[SerializeField]
	private RaftMovementAudioController _movementAudioController;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private float _lightImpactSpeedThreshold;
	[SerializeField]
	private float _mediumImpactSpeedThreshold;
	[SerializeField]
	private float _heavyImpactSpeedThreshold;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource[] _impactSources;
	[SerializeField]
	private ParticleSystem[] _churnParticles;
}
