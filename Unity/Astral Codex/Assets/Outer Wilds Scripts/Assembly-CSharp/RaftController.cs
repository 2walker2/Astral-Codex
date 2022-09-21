using UnityEngine;

public class RaftController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private bool _debug;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private LightSensor[] _lightSensors;
	[SerializeField]
	private Shape _detectorShape;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private RaftFluidDetector _fluidDetector;
	[SerializeField]
	private OWTriggerVolume _rideVolume;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWCollider[] _railingColliders;
	[SerializeField]
	private Animator _railingAnimator;
	[SerializeField]
	private float _dropDelay;
}
