using UnityEngine;

public class OrbitalProbeLaunchController : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _probeBody;
	[SerializeField]
	private OWRigidbody[] _fakeDebrisBodies;
	[SerializeField]
	private SectorProxy[] _realDebrisSectorProxies;
	[SerializeField]
	private ParticleSystem[] _launchParticles;
	[SerializeField]
	private bool _debugShowCannonBreaking;
}
