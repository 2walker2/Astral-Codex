using UnityEngine;

public class MapMarker : MonoBehaviour
{
	private enum MarkerType
	{
		Default = 0,
		Planet = 1,
		Moon = 2,
		Sun = 3,
		Player = 4,
		Probe = 5,
		Ship = 6,
		HourglassTwins = 7,
		ShipLog = 8,
	}

	[SerializeField]
	private UITextType _labelID;
	[SerializeField]
	private MarkerType _markerType;
	[SerializeField]
	private Color _customMarkerColor;
	[SerializeField]
	private FogWarpDetector _fogWarpDetector;
}
