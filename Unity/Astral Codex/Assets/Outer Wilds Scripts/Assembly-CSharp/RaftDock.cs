using UnityEngine;

public class RaftDock : RaftCarrier
{
	[SerializeField]
	private RaftController _startRaft;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearInterface;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private Transform _raftSocket;
	[SerializeField]
	private OWTriggerVolume _raftDetectorVolume;
	[SerializeField]
	private RaftDockLights _lightsController;
	[SerializeField]
	private Transform _raftProxyColliderRoot;
	[SerializeField]
	private OWCollider[] _raftProxyColliders;
	[SerializeField]
	private float _postFloodDisableTime;
}
