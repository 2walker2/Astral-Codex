using UnityEngine;

public class PrisonerBrain : MonoBehaviour
{
	[SerializeField]
	private string _name;
	[SerializeField]
	private GhostNode.NodeLayer _nodeLayer;
	[SerializeField]
	private PrisonerEffects _effects;
	[SerializeField]
	private OWTriggerVolume _blockMovementVolume;
	[SerializeField]
	private OWTriggerVolume _allowMovementVolume;
}
