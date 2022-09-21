using UnityEngine;

public class GravityVolume : ForceVolume
{
	private enum FalloffType
	{
		linear = 0,
		inverseSquared = 1,
		constant = 2,
	}

	[SerializeField]
	private bool _isPlanetGravityVolume;
	[SerializeField]
	protected float _surfaceAcceleration;
	[SerializeField]
	private float _cutoffAcceleration;
	[SerializeField]
	private FalloffType _falloffType;
	[SerializeField]
	private float _alignmentRadius;
	[SerializeField]
	private float _upperSurfaceRadius;
	[SerializeField]
	private float _lowerSurfaceRadius;
	[SerializeField]
	private float _cutoffRadius;
	[SerializeField]
	private bool _setMass;
}
