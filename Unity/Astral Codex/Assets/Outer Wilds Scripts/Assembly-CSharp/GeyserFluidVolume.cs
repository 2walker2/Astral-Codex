using UnityEngine;

public class GeyserFluidVolume : FluidVolume
{
	[SerializeField]
	private float _directionalFlowSpeed;
	[SerializeField]
	private float _attractionalFlowSpeed;
	[SerializeField]
	private float _climbSpeed;
	[SerializeField]
	private float _attractionalRadiusFallOff;
}
