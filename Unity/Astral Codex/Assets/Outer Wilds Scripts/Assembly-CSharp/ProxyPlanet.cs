using UnityEngine;

public class ProxyPlanet : ProxyBody
{
	[SerializeField]
	protected Renderer _atmosphere;
	[SerializeField]
	protected Renderer _fog;
	[SerializeField]
	protected float _mieCurveMinDistance;
	[SerializeField]
	protected float _mieCurveMaxDistance;
	[SerializeField]
	protected float _mieCurveMinVal;
	[SerializeField]
	protected float _mieCurveMaxVal;
	[SerializeField]
	protected AnimationCurve _mieCurve;
	[SerializeField]
	protected float _fogCurveMinDistance;
	[SerializeField]
	protected float _fogCurveMaxDistance;
	[SerializeField]
	protected float _fogCurveMinVal;
	[SerializeField]
	protected float _fogCurveMaxVal;
	[SerializeField]
	protected AnimationCurve _fogCurve;
}
