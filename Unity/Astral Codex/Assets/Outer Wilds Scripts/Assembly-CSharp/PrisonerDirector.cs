using UnityEngine;

public class PrisonerDirector : MonoBehaviour
{
	[SerializeField]
	private GhostController _prisonerController;
	[SerializeField]
	private PrisonerBrain _prisonerBrain;
	[SerializeField]
	private PrisonerEffects _prisonerEffects;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private PrisonCellElevator _cellevator;
	[SerializeField]
	private OWTriggerVolume _prisonEntryTrigger;
	[SerializeField]
	private OWTriggerVolume _callCellevatorTrigger;
	[SerializeField]
	private OWTriggerVolume _emergeTrigger;
	[SerializeField]
	private Transform _lanternTableSocket;
	[SerializeField]
	private CharacterDialogueTree _characterDialogueTree;
	[SerializeField]
	private OWFlameController _prisonLighting;
	[SerializeField]
	private OWRendererFadeController _alcoveDarkness;
	[SerializeField]
	private OWCollider _alcoveCollider;
	[SerializeField]
	private OWAudioSource _hangingLampSource;
	[SerializeField]
	private AudioVolume _lightsOnAudioVolume;
	[SerializeField]
	private OWTriggerVolume _lightsOutTrigger;
	[SerializeField]
	private VisionTorchItem _visionTorchItem;
	[SerializeField]
	private Shape _prisonerDetector;
	[SerializeField]
	private MindSlideCollection _storyReel5_Complete;
	[SerializeField]
	private MindSlideCollection _storyReel5_NoInterloper;
	[SerializeField]
	private MindSlideCollection _storyReel5_NoInterloperNoVessel;
	[SerializeField]
	private MindSlideCollection _storyReel5_NoVessel;
	[SerializeField]
	private VisionTorchSocket _prisonerTorchSocket;
	[SerializeField]
	private Transform _torchCueMarker;
	[SerializeField]
	private Transform _scanCueMarker;
	[SerializeField]
	private Transform _torchReturnCueMarker;
	[SerializeField]
	private OWCollider _cellevatorLowerDoorProxyCollider;
	[SerializeField]
	private RotatingDoor _cellevatorLowerDoor;
	[SerializeField]
	private Transform _cellevatorPedestalMarker;
	[SerializeField]
	private GhostNodeMap _cellevatorNodeMap;
	[SerializeField]
	private DreamLibraryPedestal _cellevatorPedestal;
	[SerializeField]
	private Transform _cellevatorWindowMarker;
	[SerializeField]
	private RotatingDoor _cellevatorUpperDoor;
	[SerializeField]
	private GhostNodeMap _upperFloorNodeMap;
	[SerializeField]
	private Transform _exitCueMarker;
	[SerializeField]
	private OWTriggerVolume _sendCellevatorDownTrigger;
	[SerializeField]
	private GameObject _farewellTorchProjector;
	[SerializeField]
	private AudioVolume _quietAudioVolume;
	[SerializeField]
	private DreamCandle[] _dreamCandles;
}
