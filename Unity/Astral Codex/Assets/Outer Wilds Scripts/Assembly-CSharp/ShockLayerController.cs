using UnityEngine;

public class ShockLayerController : MonoBehaviour
{
	[SerializeField]
	private ShockLayerRuleset _rulesetOverride;
	[SerializeField]
	private RulesetDetector _rulesetDetector;
	[SerializeField]
	private FluidDetector _fluidDetector;
}
