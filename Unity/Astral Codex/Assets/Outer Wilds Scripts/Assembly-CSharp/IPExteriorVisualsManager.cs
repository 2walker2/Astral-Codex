using UnityEngine;

public class IPExteriorVisualsManager : SectoredMonoBehaviour
{
	[SerializeField]
	private Renderer[] _exteriorVisualsRenderers;
	[SerializeField]
	private Renderer[] _cockpitExteriorVisuals;
	[SerializeField]
	private Renderer[] _observationDeckHiddenVisuals;
	[SerializeField]
	private Sector _cockpitSector;
	[SerializeField]
	private Sector _observationDeckSector;
}
