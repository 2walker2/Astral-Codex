using UnityEngine;
using UnityEngine.UI;

public class MapSatelliteDataReadout : SectoredMonoBehaviour
{
	[SerializeField]
	private Canvas _readoutCanvas;
	[SerializeField]
	private Text _planeAngleText;
	[SerializeField]
	private MapSatelliteStateController _satelliteStateController;
}
