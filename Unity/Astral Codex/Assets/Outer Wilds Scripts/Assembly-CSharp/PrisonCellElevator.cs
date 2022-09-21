using UnityEngine;

public class PrisonCellElevator : MonoBehaviour
{
	[SerializeField]
	private DreamLibraryPedestal _pedestal;
	[SerializeField]
	private OWLightController _pedestalSymbol;
	[SerializeField]
	private OWRigidbody _elevatorBody;
	[SerializeField]
	private OWCollider _proxyCollider;
	[SerializeField]
	private OWTriggerVolume[] _killTriggers;
	[SerializeField]
	private AbstractDoor _topDoor;
	[SerializeField]
	private OWCollider _topDoorProxyCollider;
	[SerializeField]
	private AbstractDoor _bottomDoor;
	[SerializeField]
	private OWCollider _bottomDoorProxyCollider;
	[SerializeField]
	private Transform[] _floors;
	[SerializeField]
	private int _startFloorIndex;
	[SerializeField]
	private float _maxAccel;
	[SerializeField]
	private float _maxDecel;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _musicAudio;
}
