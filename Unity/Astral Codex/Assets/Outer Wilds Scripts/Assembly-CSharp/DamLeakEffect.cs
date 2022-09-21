using UnityEngine;

public class DamLeakEffect : MonoBehaviour
{
	[SerializeField]
	private float _delay;
	[SerializeField]
	private OWRenderer[] _renderers;
	[SerializeField]
	private ParticleSystem[] _particles;
}
