using UnityEngine;

public class FluidVolume : PriorityVolume
{
	public enum Type
	{
		NONE = 0,
		AIR = 1,
		WATER = 2,
		TRACTOR_BEAM = 3,
		CLOUD = 4,
		SAND = 5,
		PLASMA = 6,
		FOG = 7,
		GEYSER = 8,
	}

	[SerializeField]
	protected float _density;
	[SerializeField]
	protected Type _fluidType;
	[SerializeField]
	protected bool _alignmentFluid;
	[SerializeField]
	protected bool _allowShipAutoroll;
	[SerializeField]
	private bool _disableOnStart;
}
