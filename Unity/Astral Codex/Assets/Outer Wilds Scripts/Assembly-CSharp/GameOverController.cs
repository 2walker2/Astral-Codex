using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
	[SerializeField]
	private Canvas _gameOverTextCanvas;
	[SerializeField]
	private Text _deathText;
	[SerializeField]
	private int _deathTextMaxFontSize;
	[SerializeField]
	private CanvasGroupAnimator _textAnimator;
	[SerializeField]
	private AnimationCurve _fadeInCurve;
	[SerializeField]
	private AnimationCurve _fadeOutCurve;
	[SerializeField]
	private CanvasGroupAnimator _whiteFadeAnimator;
	[SerializeField]
	private AnimationCurve _whiteFadeCurve;
}
