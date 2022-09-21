using UnityEngine;

public class SunController : MonoBehaviour
{
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private LODGroup _atmosphere;
	[SerializeField]
	private PlanetaryFogController _fog;
	[SerializeField]
	private ShockLayerRuleset _shockLayerRuleset;
	[SerializeField]
	private TessellatedSphereRenderer _surface;
	[SerializeField]
	private Transform _scaledVolumesRoot;
	[SerializeField]
	private SolarFlareEmitter _solarFlareEmitter;
	[SerializeField]
	private SunLightController _sunLight;
	[SerializeField]
	private SupernovaEffectController _supernova;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Transform _lightShaftRoot;
	[SerializeField]
	private float _progressionStartTime;
	[SerializeField]
	private float _progressionEndTime;
	[SerializeField]
	private float _endScale;
	[SerializeField]
	private float _fogEndRadius;
	[SerializeField]
	private float _fogEndFadeDistance;
	[SerializeField]
	private float _scaleStartTime;
	[SerializeField]
	private float _scaleEndTime;
	[SerializeField]
	private Gradient _atmosphereColor;
	[SerializeField]
	private Material _startSurfaceMaterial;
	[SerializeField]
	private Material _endSurfaceMaterial;
	[SerializeField]
	private Gradient _solarFlareTint;
	[SerializeField]
	private float _endLightIntensity;
	[SerializeField]
	private Gradient _lightColor;
	[SerializeField]
	private float _collapseLength;
	[SerializeField]
	private float _collapsedScale;
	[SerializeField]
	private ParticleSystem[] _collapseParticles;
	[SerializeField]
	private Gradient _collapseAtmosphereColor;
	[SerializeField]
	private Material _collapseTransitionMaterial;
	[SerializeField]
	private Material _collapseStartSurfaceMaterial;
	[SerializeField]
	private Material _collapseEndSurfaceMaterial;
	[SerializeField]
	private Color _lightBlastColor;
	[SerializeField]
	private AnimationCurve _lightFlareCurve;
}
