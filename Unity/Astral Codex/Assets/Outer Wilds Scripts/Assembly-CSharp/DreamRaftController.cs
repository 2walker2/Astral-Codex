using UnityEngine;

public class DreamRaftController : MonoBehaviour
{
	[SerializeField]
	private float _turboSpeed;
	[SerializeField]
	private LightSensor _turboSensor;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private DreamRiverFluidVolume _riverFluid;
	[SerializeField]
	private DreamRaftFluidDetector _fluidDetector;
	[SerializeField]
	private OWCollider[] _colliders;
	[SerializeField]
	private Shape[] _shapes;
}
