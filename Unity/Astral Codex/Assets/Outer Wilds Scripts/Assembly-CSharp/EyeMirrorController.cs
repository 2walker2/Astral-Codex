using UnityEngine;

public class EyeMirrorController : MonoBehaviour
{
	[SerializeField]
	private OWLight2 _planetFillLight;
	[SerializeField]
	private AbstractDoor _door;
	[SerializeField]
	private EyeTombPortrait[] _portraits;
	[SerializeField]
	private OWTriggerVolume _tombVolume;
	[SerializeField]
	private OWTriggerVolume _probeDestructionVolume;
	[SerializeField]
	private EndlessCylinder _forestCylinder;
	[SerializeField]
	private OWTriggerVolume _closeDoorTrigger;
	[SerializeField]
	private AudioSignal _buriedSignal;
	[SerializeField]
	private AudioSignal _instrumentSignal;
	[SerializeField]
	private DreamCandle _dreamCandle;
	[SerializeField]
	private OWFlameController _mirrorCandle;
	[SerializeField]
	private GameObject _mirrorPlayer;
	[SerializeField]
	private VisibilityObject _mirrorVisibilityObject;
	[SerializeField]
	private GameObject _mirrorProbe;
	[SerializeField]
	private Transform _mirrorProbeScaleRoot;
	[SerializeField]
	private Transform _mirrorProbeCenterBone;
	[SerializeField]
	private GameObject _mummyObject;
	[SerializeField]
	private GameObject _tunnelBlocker;
	[SerializeField]
	private VisibilityObject _instrumentVisibilityObject;
	[SerializeField]
	private OWRigidbody _instrumentBody;
	[SerializeField]
	private OWAudioSource _instrumentImpactAudio;
}
