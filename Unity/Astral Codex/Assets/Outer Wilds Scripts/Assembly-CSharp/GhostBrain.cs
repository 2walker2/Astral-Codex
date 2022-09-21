using UnityEngine;

public class GhostBrain : MonoBehaviour
{
	[SerializeField]
	private bool _debug;
	[SerializeField]
	private string _name;
	[SerializeField]
	private bool _startWithLanternConcealed;
	[SerializeField]
	private GhostNode.NodeLayer _nodeLayer;
	[SerializeField]
	private GhostAction.Name[] _actions;
	[SerializeField]
	private GhostEffects _effects;
	[SerializeField]
	private GhostBrain[] _helperGhosts;
	[SerializeField]
	private OWTriggerVolume _guardVolume;
	[SerializeField]
	private Transform _chokePoint;
	[SerializeField]
	private bool _reducedFrights_allowChase;
}
