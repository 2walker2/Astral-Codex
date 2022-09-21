using UnityEngine;

public class SectorLightsLODGroup : LightsCullGroup
{
	[SerializeField]
	private Sector _LODsector;
	[SerializeField]
	private Sector _sectorWhereActive;
	[SerializeField]
	private float _fadeLength;
}
