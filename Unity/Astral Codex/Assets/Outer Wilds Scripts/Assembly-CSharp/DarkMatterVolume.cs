using UnityEngine;

public class DarkMatterVolume : HazardVolume
{
	[SerializeField]
	protected ParticleSystem _particleTrail;
	[SerializeField]
	protected float _rateOverTime;
	[SerializeField]
	protected float _rateOverDistance;
}
