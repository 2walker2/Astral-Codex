using UnityEngine;

public class MaskZoneController : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _maskZoneTrigger;
	[SerializeField]
	private EyeShuttleController _shuttle;
	[SerializeField]
	private GameObject _whiteSphere;
	[SerializeField]
	private VisibilityTracker _sphereVisibilityTracker;
	[SerializeField]
	private QuantumSkeletonTower _skeletonTower;
	[SerializeField]
	private QuantumInstrument _maskInstrument;
	[SerializeField]
	private Transform _returnSocket;
	[SerializeField]
	private AudioSignal _groundSignal;
	[SerializeField]
	private AudioSignal _skySignal;
}
