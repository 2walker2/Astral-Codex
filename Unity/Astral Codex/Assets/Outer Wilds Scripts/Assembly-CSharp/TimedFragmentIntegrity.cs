using UnityEngine;

public class TimedFragmentIntegrity : FragmentIntegrity
{
	[SerializeField]
	private float _earliestTime;
	[SerializeField]
	private float _latestTime;
	[SerializeField]
	protected float _damageMultiplierWhenTime;
}
