using UnityEngine;

public class SinkholeFluidVolume : FluidVolume
{
	[SerializeField]
	private Vector3 _vortexCenter;
	[SerializeField]
	private Vector3 _vortexDirection;
	[SerializeField]
	private float _vortexSuctionRadius;
	[SerializeField]
	private float _downwardFlowSpeed;
	[SerializeField]
	private float _inwardFlowSpeed;
}
