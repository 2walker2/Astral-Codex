using UnityEngine;

public class NomaiAirlockEffectController : MonoBehaviour
{
	[SerializeField]
	private NomaiAirlock _airlock;
	[SerializeField]
	private ParticleSystem _airPourInParticles;
	[SerializeField]
	private ParticleSystem _airPourOutParticles;
	[SerializeField]
	private FluidVolume _pouringFluid;
	[SerializeField]
	private float _fluidPourDuration;
}
