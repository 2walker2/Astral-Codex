using UnityEngine;

public class DamRaftLift : RaftCarrier
{
	[SerializeField]
	private Transform[] _liftNodes;
	[SerializeField]
	private Transform _craneRoot;
	[SerializeField]
	private Transform[] _craneWheels;
	[SerializeField]
	private float _hookReturnSpeed;
	[SerializeField]
	private float _craneReturnSpeed;
	[SerializeField]
	private RaftDockLights _raftDockLights;
	[SerializeField]
	private OWRenderer[] _hookRenderers;
}
