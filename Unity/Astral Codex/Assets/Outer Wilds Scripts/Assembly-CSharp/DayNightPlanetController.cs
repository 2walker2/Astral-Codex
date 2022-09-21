using UnityEngine;

public class DayNightPlanetController : MonoBehaviour
{
	[SerializeField]
	private OWLight2 _ambientLight;
	[SerializeField]
	private PlanetaryFogController _planetaryFog;
	[SerializeField]
	private MeshRenderer _atmosphereRenderer;
	[SerializeField]
	private OWTriggerVolume _headsVolume;
	[SerializeField]
	private OWTriggerVolume _tailsVolume;
}
