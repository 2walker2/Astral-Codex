using UnityEngine;

public class SectorRendererLODGroup : CullGroup
{
	[SerializeField]
	private Sector _LODsector;
	[SerializeField]
	private Sector _sectorWhereActive;
}
