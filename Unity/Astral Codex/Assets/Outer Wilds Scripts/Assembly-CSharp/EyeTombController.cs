using UnityEngine;

public class EyeTombController : MonoBehaviour
{
	[SerializeField]
	private ObserveTrigger _graveObserveTrigger;
	[SerializeField]
	private GameObject _stageRoot;
	[SerializeField]
	private OWTriggerVolume _stageVolume;
	[SerializeField]
	private OWLightController _candleController;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearEffects;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Transform _lockOnTransform;
	[SerializeField]
	private OWLightController _planetLightController;
	[SerializeField]
	private OWRendererFadeController _lightBeamController;
	[SerializeField]
	private GameObject _planetObject;
	[SerializeField]
	private GameObject _stateRoot;
	[SerializeField]
	private GameObject[] _states;
	[SerializeField]
	private AudioSignal _buriedSignal;
	[SerializeField]
	private Transform _signalDeepSocket;
	[SerializeField]
	private QuantumInstrument _instrument;
	[SerializeField]
	private GameObject _finalTombState;
	[SerializeField]
	private Transform _returnSocket;
}
