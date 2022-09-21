using UnityEngine;

public class SupernovaPlanetEffectController : MonoBehaviour
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private LODGroup _atmosphere;
	[SerializeField]
	private PlanetaryFogController _fog;
	[SerializeField]
	private MeshRenderer _shockLayer;
	[SerializeField]
	private Color _shockLayerColor;
	[SerializeField]
	private float _shockLayerStartRadius;
	[SerializeField]
	private float _shockLayerFullRadius;
	[SerializeField]
	private float _shockLayerTrailLength;
	[SerializeField]
	private float _shockLayerTrailFlare;
}
