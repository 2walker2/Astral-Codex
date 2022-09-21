using UnityEngine;

public class VisorEffectController : MonoBehaviour
{
	[SerializeField]
	private OWCamera _owCamera;
	[SerializeField]
	private VisorEffectDetector _visorEffectDetector;
	[SerializeField]
	private Renderer _visorEffectRenderer;
	[SerializeField]
	private ParticleSystem _rainDropletsParticleSystem;
	[SerializeField]
	private ParticleSystem _rainStreaksParticleSystem;
	[SerializeField]
	private float _dirtClearLength;
	[SerializeField]
	private float _equilibriumDirt;
	[SerializeField]
	private float _maxDirt;
	[SerializeField]
	private float _dirtDecayRate;
	[SerializeField]
	private float _waterFadeInLength;
	[SerializeField]
	private float _waterClearLength;
	[SerializeField]
	private float _waterOffsetStart;
	[SerializeField]
	private float _waterOffsetEnd;
	[SerializeField]
	private int _waterNumDroplets;
	[SerializeField]
	private float _waterNumStreaks;
	[SerializeField]
	private float _frostThawRate;
	[SerializeField]
	private float _defrostRate;
	[SerializeField]
	private PlayerCameraFluidDetector _cameraFluidDetector;
	[SerializeField]
	private AnimationCurve _breathFogCurve;
	[SerializeField]
	private float _breathFogRandomness;
	[SerializeField]
	private float _breathFogFadeInLength;
	[SerializeField]
	private float _breathFogFadeOutLength;
	[SerializeField]
	private Renderer _crackEffectRenderer;
	[SerializeField]
	private AnimationCurve _impactCrackAnimCurve;
	[SerializeField]
	private AnimationCurve _crushedCrackAnimCurve;
}
