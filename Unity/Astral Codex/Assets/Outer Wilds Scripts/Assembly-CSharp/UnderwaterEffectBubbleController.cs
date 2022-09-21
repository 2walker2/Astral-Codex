using UnityEngine;

public class UnderwaterEffectBubbleController : MonoBehaviour
{
	[SerializeField]
	private RulesetDetector _rulesetDetector;
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private OWCamera _targetCamera;
	[SerializeField]
	private OWCamera _altTargetCamera;
	[SerializeField]
	private DampedSpringQuat _alignmentSpring;
	[SerializeField]
	private DampedSpring _speedDistortSpring;
}
