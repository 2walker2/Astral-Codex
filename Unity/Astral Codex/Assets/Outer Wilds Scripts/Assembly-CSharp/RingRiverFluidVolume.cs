using UnityEngine;

public class RingRiverFluidVolume : FluidVolume
{
	[SerializeField]
	private bool _debugIgnoreCurrents;
	[SerializeField]
	private bool _updateMarkers;
	[SerializeField]
	private float _defaultSpeed;
	[SerializeField]
	private float _densityForPlayer;
	[SerializeField]
	private float _buoyancyDensity;
	[SerializeField]
	private GameObject _preFloodFlowMarkers;
	[SerializeField]
	private GameObject _postFloodFlowMarkers;
	[SerializeField]
	private GameObject _undertowVolumesRoot;
	[SerializeField]
	private bool _flowMarkersCached;
	[SerializeField]
	private RiverMarkerGroup _preFloodMarkers;
	[SerializeField]
	private RiverMarkerGroup _postFloodMarkers;
}
