using UnityEngine;

public class CreditsFadeSection : CreditsSection
{
	[SerializeField]
	private float _fadeInDuration;
	[SerializeField]
	private float _displayDuration;
	[SerializeField]
	private float _fadeOutDuration;
	[SerializeField]
	private float _waitDuration;
	[SerializeField]
	private FadeChildren _fadeComponent;
	[SerializeField]
	private AnimationCurve _fadeCurve;
}
