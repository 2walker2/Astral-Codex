using UnityEngine;

public class SectorCullGroup : CullGroup
{
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	protected SectorProxy _controllingProxy;
}
