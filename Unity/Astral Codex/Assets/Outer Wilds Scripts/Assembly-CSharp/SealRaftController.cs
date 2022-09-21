using UnityEngine;

public class SealRaftController : MonoBehaviour
{
	[SerializeField]
	private AbstractGhostDoorInterface _codeInterface;
	[SerializeField]
	private Transform _nearNode;
	[SerializeField]
	private Transform _farNode;
	[SerializeField]
	private LightSensor _nearSensor;
	[SerializeField]
	private LightSensor _farSensor;
	[SerializeField]
	private OWCollider[] _colliders;
	[SerializeField]
	private Shape[] _shapes;
	[SerializeField]
	private AlignToSurfaceFluidDetector _fluidDetector;
	[SerializeField]
	private float _minSpeed;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private OWAudioSource _audioSource;
}
