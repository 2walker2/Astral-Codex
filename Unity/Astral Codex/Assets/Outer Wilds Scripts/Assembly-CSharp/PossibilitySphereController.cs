using UnityEngine;
using System;

public class PossibilitySphereController : MonoBehaviour
{
	[Serializable]
	private struct ProbabilityParticleSystem
	{
		public ParticleSystem particleSystem;
		public float probability;
	}

	[SerializeField]
	private float _minIntensity;
	[SerializeField]
	private float _fadeInDuration;
	[SerializeField]
	private float _litDuration;
	[SerializeField]
	private float _fadeOutDuration;
	[SerializeField]
	private float _unlitDuration;
	[SerializeField]
	private OWLight[] _lights;
	[SerializeField]
	private ProbabilityParticleSystem[] _particles;
	[SerializeField]
	private Transform[] _randomRotationRoots;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource _ambientSource;
	[SerializeField]
	private GameObject _prisonerObject;
	[SerializeField]
	private LightSensor _prisonerLightSensor;
	[SerializeField]
	private OWEmissiveRenderer[] _prisonerEyeRenderers;
}
