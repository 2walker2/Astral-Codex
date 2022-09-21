using UnityEngine;

public class DamDestructionController : MonoBehaviour
{
	[SerializeField]
	private RingWorldController _ringworldController;
	[SerializeField]
	private Sector _interiorSector;
	[SerializeField]
	private float _startIntegrity;
	[SerializeField]
	private float _damagedIntegrity;
	[SerializeField]
	private OWRenderer _leakRenderer;
	[SerializeField]
	private AnimationCurve _leakProgressionCurve;
	[SerializeField]
	private float _leakFadeOutLength;
	[SerializeField]
	private GameObject _intactDamRoot;
	[SerializeField]
	private GameObject _destroyedDamRoot;
	[SerializeField]
	private Collider _destroyedDamAnchorCollider;
	[SerializeField]
	private DamFragmentController[] _damFragments;
	[SerializeField]
	private OWRigidbody[] _centerFragments;
	[SerializeField]
	private OWRigidbody[] _topFragments;
	[SerializeField]
	private Transform _destructionForceCenter;
	[SerializeField]
	private float _destructionForceRadius;
	[SerializeField]
	private float _destructionForceLinearAccel;
	[SerializeField]
	private float _destructionForceAngularAccel;
	[SerializeField]
	private float _destructionForceDuration;
	[SerializeField]
	private float _topFragmentsDelay;
	[SerializeField]
	private ParticleSystem[] _destructionParticles;
	[SerializeField]
	private Vector3 _probeEjectLocalDir;
	[SerializeField]
	private float _probeEjectSpeed;
}
