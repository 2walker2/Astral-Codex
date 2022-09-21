using UnityEngine;

public class ProbeLantern : MonoBehaviour
{
	[SerializeField]
	private float _fadeInDuration;
	[SerializeField]
	private AnimationCurve _fadeInCurve;
	[SerializeField]
	private AnimationCurve _fadeOutCurve;
	[SerializeField]
	private OWEmissiveRenderer _emissiveRenderer;
}
