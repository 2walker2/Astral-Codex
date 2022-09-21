using UnityEngine;

public class SectorLightsCullGroup : LightsCullGroup
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _fadeLength;
}
