using UnityEngine;

public class WhiteHoleFluidVolume : FluidVolume
{
	[SerializeField]
	private float _outerRadius;
	[SerializeField]
	private float _innerRadius;
	[SerializeField]
	private AnimationCurve _densityCurve;
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private float _massiveFlowSpeed;
}
