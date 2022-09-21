using UnityEngine;

public class ThrustRuleset : RulesetVolume
{
	[SerializeField]
	private float _thrustLimit;
	[SerializeField]
	private bool _nerfJetpackBooster;
	[SerializeField]
	private float _nerfDuration;
}
