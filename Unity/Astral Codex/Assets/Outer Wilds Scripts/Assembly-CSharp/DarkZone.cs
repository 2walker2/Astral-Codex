using UnityEngine;

public class DarkZone : MonoBehaviour
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private PlanetaryFogController _planetaryFog;
	[SerializeField]
	private FogOverrideVolume _fogOverride;
	[SerializeField]
	private SandFunnelController _sandFunnel;
	[SerializeField]
	private OWRenderer _entryFogPlane;
	[SerializeField]
	private OWRenderer _exitFogPlane;
	[SerializeField]
	private float _transitionTime;
}
