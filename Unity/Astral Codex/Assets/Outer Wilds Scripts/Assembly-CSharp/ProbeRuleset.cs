using UnityEngine;

public class ProbeRuleset : RulesetVolume
{
	[SerializeField]
	private bool _overrideProbeSpeed;
	[SerializeField]
	private float _probeSpeedOverride;
	[SerializeField]
	private bool _overrideLanternRange;
	[SerializeField]
	private float _lanternRange;
	[SerializeField]
	private bool _ignoreAnchor;
}
