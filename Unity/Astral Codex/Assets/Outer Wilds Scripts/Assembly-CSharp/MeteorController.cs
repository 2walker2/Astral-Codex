using UnityEngine;

public class MeteorController : MonoBehaviour
{
	[SerializeField]
	private float _minDamage;
	[SerializeField]
	private float _maxDamage;
	[SerializeField]
	private ConstantForceDetector _constantForceDetector;
	[SerializeField]
	private ConstantFluidDetector _constantFluidDetector;
	[SerializeField]
	private DynamicFluidDetector _dynamicFluidDetector;
	[SerializeField]
	private Renderer _intactRenderer;
	[SerializeField]
	private Light _glowLight;
	[SerializeField]
	private FluidTrailEmitter _smokeTrail;
	[SerializeField]
	private float _nonCollisionDuration;
	[SerializeField]
	private float _ambientCoolTime;
	[SerializeField]
	private float _impactedCoolTime;
	[SerializeField]
	private float _waterCoolTime;
	[SerializeField]
	private float _atmoEntryHeatScale;
	[SerializeField]
	private float _lightFadeTime;
	[SerializeField]
	private float _impactSuspendDelay;
	[SerializeField]
	private ParticleSystem[] _impactParticles;
	[SerializeField]
	private Light _impactLight;
	[SerializeField]
	private AnimationCurve _impactLightCurve;
	[SerializeField]
	private OWAudioSource _impactSource;
}
