using UnityEngine;

public class ShockLayerRuleset : RulesetVolume
{
	public enum ShockType
	{
		None = 0,
		Radial = 1,
		Atmospheric = 2,
	}

	[SerializeField]
	private ShockType _type;
	[SerializeField]
	private Transform _radialCenter;
	[SerializeField]
	private float _innerRadius;
	[SerializeField]
	private float _outerRadius;
	[SerializeField]
	private Color _color;
	[SerializeField]
	private float _minShockSpeed;
	[SerializeField]
	private float _maxShockSpeed;
	[SerializeField]
	private float _trailLength;
	[SerializeField]
	private float _trailFlare;
}
