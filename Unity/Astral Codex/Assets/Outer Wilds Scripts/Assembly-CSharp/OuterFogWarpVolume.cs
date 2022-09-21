using UnityEngine;

public class OuterFogWarpVolume : SphericalFogWarpVolume
{
	public enum Name
	{
		None = 0,
		Hub = 1,
		EscapePod = 2,
		AnglerNest = 3,
		Pioneer = 4,
		ExitOnly = 5,
		Vessel = 6,
		Cluster = 7,
		SmallNest = 8,
	}

	[SerializeField]
	private InnerFogWarpVolume _linkedInnerWarpVolume;
	[SerializeField]
	private Name _name;
}
