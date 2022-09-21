using UnityEngine;

public class TitleAnimationController : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[SerializeField]
	private float _logoFadeDelay;
	[SerializeField]
	private float _logoFadeDuration;
	[SerializeField]
	private float _echoesFadeDelay;
	[SerializeField]
	private float _optionsFadeDelay;
	[SerializeField]
	private float _optionsFadeDuration;
	[SerializeField]
	private float _optionsFadeSpacing;
	[SerializeField]
	private CanvasGroupFadeController _logoFadeController;
	[SerializeField]
	private CanvasGroupFadeController _echoesFadeController;
	[SerializeField]
	private CanvasGroupFadeController[] _buttonFadeControllers;
	[SerializeField]
	private CanvasGroupFadeController _footerFadeController;
	[SerializeField]
	private Animator _titleAnimator;
}
