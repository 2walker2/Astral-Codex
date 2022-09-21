using UnityEngine;

public class RingWaveFluidVolume : FluidVolume
{
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _buoyancyDensity;
}
