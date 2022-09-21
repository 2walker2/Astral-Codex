using UnityEngine;

public class MapMarkerManager : MonoBehaviour
{
	[SerializeField]
	private GameObject _canvasMarkerTemplate;
	[SerializeField]
	private GameObject _locatorMarkerTemplate;
	[SerializeField]
	private Camera _mapCamera;
	[SerializeField]
	private FontAndLanguageController _markerFontController;
}
