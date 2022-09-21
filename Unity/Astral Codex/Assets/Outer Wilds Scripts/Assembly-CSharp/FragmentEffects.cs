using UnityEngine;

public class FragmentEffects : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] _impactParticles;
	[SerializeField]
	private ParticleSystem[] _detachmentParticles;
	[SerializeField]
	private ParticleSystem[] _destructionParticles;
	[SerializeField]
	private OWRenderer[] _destructionRenderers;
	[SerializeField]
	private float _destructionDissolveLength;
}
