using UnityEngine;

public class OWRingRiverCollider : OWCapsuleCollider
{
	[SerializeField]
	private float _rampStartDegrees;
	[SerializeField]
	private float _rampEndDegrees;
	[SerializeField]
	private AnimationCurve _rampCurve;
	[SerializeField]
	private float _waveDeltaDegrees;
	[SerializeField]
	private AnimationCurve _waveFrontCurve;
	[SerializeField]
	private AnimationCurve _waveToDamCurve;
	[SerializeField]
	private AnimationCurve _damDrainCurve;
	[SerializeField]
	private AnimationCurve _downhillElevationToSpeedCurve;
	[SerializeField]
	private float _innerRadiusLow;
	[SerializeField]
	private float _innerRadiusHigh;
	[SerializeField]
	private float _innerRadiusFinal;
	[SerializeField]
	private float _outerRadius;
}
