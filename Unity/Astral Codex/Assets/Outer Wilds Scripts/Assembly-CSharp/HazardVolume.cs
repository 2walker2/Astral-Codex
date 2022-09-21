using UnityEngine;

public class HazardVolume : EffectVolume
{
	public enum HazardType
	{
		NONE = 0,
		GENERAL = 1,
		DARKMATTER = 2,
		HEAT = 4,
		FIRE = 8,
		SANDFALL = 16,
		ELECTRICITY = 32,
		RAPIDS = 64,
	}

	[SerializeField]
	protected float _firstContactDamage;
	[SerializeField]
	protected InstantDamageType _firstContactDamageType;
	[SerializeField]
	protected float _damagePerSecond;
}
