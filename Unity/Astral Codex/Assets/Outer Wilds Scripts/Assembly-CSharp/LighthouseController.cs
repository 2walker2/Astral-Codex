using UnityEngine;

public class LighthouseController : MonoBehaviour
{
	[SerializeField]
	private BuildingRailController _stageOneController;
	[SerializeField]
	private BuildingRailController _stageTwoController;
	[SerializeField]
	private BuildingRailController _mapHouseStageTwoController;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private CustomCollisionChecker _floorCollisionChecker;
	[SerializeField]
	private GameObject _floorIntact;
	[SerializeField]
	private GameObject _floorDamaged;
	[SerializeField]
	private OWAudioSource _collapseAudio;
	[SerializeField]
	private OWAudioSource _splashAudio;
	[SerializeField]
	private OWLightController[] _muralRoomLights;
	[SerializeField]
	private int[] _doorLightIndices;
	[SerializeField]
	private AbstractDoor _secretDoor;
}
