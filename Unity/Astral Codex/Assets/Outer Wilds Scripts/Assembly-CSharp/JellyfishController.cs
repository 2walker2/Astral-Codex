using UnityEngine;

public class JellyfishController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _upperLimit;
	[SerializeField]
	private float _lowerLimit;
	[SerializeField]
	private float _upwardsAcceleration;
	[SerializeField]
	private float _downwardsAcceleration;
	[SerializeField]
	private FluidVolume _attractiveFluidVolume;
}
