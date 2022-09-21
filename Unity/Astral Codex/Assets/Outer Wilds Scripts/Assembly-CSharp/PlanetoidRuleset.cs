using UnityEngine;

public class PlanetoidRuleset : RulesetVolume
{
	[SerializeField]
	private float _daySideConeAngle;
	[SerializeField]
	private float _horizonRadius;
	[SerializeField]
	private bool _useMinimap;
	[SerializeField]
	private bool _useAltimeter;
	[SerializeField]
	private float _altitudeFloor;
	[SerializeField]
	private float _altitudeCeiling;
	[SerializeField]
	private float _shuttleLandingRadius;
	[SerializeField]
	private SandLevelController _sandLevelController;
}
