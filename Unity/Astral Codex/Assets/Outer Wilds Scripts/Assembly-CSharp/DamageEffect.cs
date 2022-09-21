using UnityEngine;

public class DamageEffect : MonoBehaviour
{
	public enum ParticleMode
	{
		Burst = 0,
		Continuous = 1,
	}

	[SerializeField]
	private OWRenderer[] _decalRenderers;
	[SerializeField]
	private SkinnedMeshRenderer[] _blendShapeRenderers;
	[SerializeField]
	private OWLight2[] _glowLights;
	[SerializeField]
	private OWRenderer _patchRenderer;
	[SerializeField]
	private OWLight2 _damageLight;
	[SerializeField]
	private OWRenderer _damageLightRenderer;
	[SerializeField]
	private float _damageLightPulseSpeed;
	[SerializeField]
	private ParticleSystem _particleSystem;
	[SerializeField]
	private ParticleMode _particleMode;
	[SerializeField]
	private Vector2 _particleBurstCount;
	[SerializeField]
	private Vector2 _particleBurstDelay;
	[SerializeField]
	private OWAudioSource _particleAudioSource;
}
