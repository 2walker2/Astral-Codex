using UnityEngine;

public class FluidTrailEmitter : MonoBehaviour
{
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private FluidVolume.Type _fluidType;
	[SerializeField]
	private float _speedScale;
	[SerializeField]
	private float _emissionRate;
	[SerializeField]
	private AnimationCurve _emissionRateDensityScale;
	[SerializeField]
	private AnimationCurve _emissionRateFluidSpeedScale;
	[SerializeField]
	private bool _startLifetimeByDensity;
	[SerializeField]
	private AnimationCurve _startLifetimeByDensityCurve;
	[SerializeField]
	private bool _startLifetimeByFluidSpeed;
	[SerializeField]
	private AnimationCurve _startLifetimeByFluidSpeedCurve;
	[SerializeField]
	private bool _startColorByDensity;
	[SerializeField]
	private float _startColorByDensityMin;
	[SerializeField]
	private float _startColorByDensityMax;
	[SerializeField]
	private Gradient _startColorByDensityGradient;
	[SerializeField]
	private bool _startColorByFluidSpeed;
	[SerializeField]
	private float _startColorByFluidSpeedMin;
	[SerializeField]
	private float _startColorByFluidSpeedMax;
	[SerializeField]
	private Gradient _startColorByFluidSpeedGradient;
}
