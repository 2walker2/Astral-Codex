using UnityEngine;

public class ThrusterWashController : MonoBehaviour
{
	[SerializeField]
	private float _raycastDistance;
	[SerializeField]
	private AnimationCurve _emissionDistanceScale;
	[SerializeField]
	private AnimationCurve _emissionThrusterScale;
	[SerializeField]
	private ParticleSystem _defaultParticleSystem;
	[SerializeField]
	private ParticleSystem[] _particleSystemBySurfaceType;
}
