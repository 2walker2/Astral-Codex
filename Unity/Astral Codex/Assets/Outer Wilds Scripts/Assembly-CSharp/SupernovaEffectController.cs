using UnityEngine;

public class SupernovaEffectController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] _explosionParticles;
	[SerializeField]
	private MeshRenderer _shockwave;
	[SerializeField]
	private float _shockwaveLength;
	[SerializeField]
	private AnimationCurve _shockwaveScale;
	[SerializeField]
	private AnimationCurve _shockwaveAlpha;
	[SerializeField]
	private TessellatedSphereRenderer _surface;
	[SerializeField]
	private Material _supernovaMaterial;
	[SerializeField]
	private SupernovaDestructionVolume _supernovaVolume;
	[SerializeField]
	private AnimationCurve _supernovaScale;
	[SerializeField]
	private AnimationCurve _supernovaAlpha;
	[SerializeField]
	private OWAudioSource _audioSource;
}
