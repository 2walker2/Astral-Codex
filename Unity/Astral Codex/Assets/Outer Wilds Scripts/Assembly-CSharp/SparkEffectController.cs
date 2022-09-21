using UnityEngine;

public class SparkEffectController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _sparkParticleSystem;
	[SerializeField]
	private Light _sparkLight;
	[SerializeField]
	private float _minSparkDelay;
	[SerializeField]
	private float _maxSparkDelay;
	[SerializeField]
	private int _minSparkCount;
	[SerializeField]
	private int _maxSparkCount;
	[SerializeField]
	private float _sparkLightFadeSpeed;
}
