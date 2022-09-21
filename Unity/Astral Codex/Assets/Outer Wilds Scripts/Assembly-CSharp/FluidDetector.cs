using UnityEngine;

public class FluidDetector : PriorityDetector
{
	[SerializeField]
	protected BuoyancyData _buoyancy;
	[SerializeField]
	private SplashEffect[] _splashEffects;
	[SerializeField]
	protected bool _dontApplyForces;
	[SerializeField]
	private Transform _splashSpawnRoot;
}
