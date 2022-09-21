using UnityEngine;

public class PlayerParticlesController : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _footstepParticlePrefabs;
	[SerializeField]
	private float _impactParticleMinSpeed;
	[SerializeField]
	private GameObject[] _impactParticlePrefabs;
}
