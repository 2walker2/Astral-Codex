using UnityEngine;

public class EffectRuleset : RulesetVolume
{
	public enum BubbleType
	{
		None = 0,
		Underwater = 1,
		FogWarp = 2,
	}

	[SerializeField]
	private BubbleType _type;
	[SerializeField]
	private Material _material;
	[SerializeField]
	private float _underwaterDistortScale;
	[SerializeField]
	private float _underwaterMinDistort;
	[SerializeField]
	private float _underwaterMaxDistort;
	[SerializeField]
	private Material _cloudMaterial;
	[SerializeField]
	private Material _sandMaterial;
}
