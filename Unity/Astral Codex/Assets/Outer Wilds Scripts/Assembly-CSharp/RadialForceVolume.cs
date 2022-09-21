using UnityEngine;

public class RadialForceVolume : ForceVolume
{
	public enum Falloff
	{
		Constant = 0,
		Linear = 1,
		InvSqr = 2,
	}

	[SerializeField]
	private Falloff _falloff;
	[SerializeField]
	private float _acceleration;
}
