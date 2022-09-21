using UnityEngine;

public class PlanetaryFogController : MonoBehaviour
{
	[SerializeField]
	private Texture3D _fogLookupTexture;
	[SerializeField]
	private float _fogRadius;
	[SerializeField]
	private float _fogDensity;
	[SerializeField]
	private float _fogExponent;
	[SerializeField]
	private Texture2D _fogColorRampTexture;
	[SerializeField]
	private float _fogColorRampIntensity;
	[SerializeField]
	private Color _fogTint;
	[SerializeField]
	private float _skyboxFactor;
	[SerializeField]
	private Renderer _fogImpostor;
	[SerializeField]
	private float _lodFadeDistance;
	[SerializeField]
	private bool _isRingworldFog;
	[SerializeField]
	private float _ringworldPlaneDist1;
	[SerializeField]
	private float _ringworldPlaneDist2;
}
