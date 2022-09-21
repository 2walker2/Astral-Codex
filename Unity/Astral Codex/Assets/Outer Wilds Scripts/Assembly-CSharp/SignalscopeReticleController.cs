using UnityEngine;
using UnityEngine.UI;

public class SignalscopeReticleController : MonoBehaviour
{
	[SerializeField]
	private Color _fullStrengthColor;
	[SerializeField]
	private Color _longDistanceColor;
	[SerializeField]
	private Sprite _fixedReticuleSprite;
	[SerializeField]
	private Sprite _dowsingBracketSprite;
	[SerializeField]
	private Transform _reticuleBracketsTransform;
	[SerializeField]
	private SkinnedMeshRenderer _dowsingBracketRTemplate;
	[SerializeField]
	private SkinnedMeshRenderer _dowsingBracketLTemplate;
	[SerializeField]
	private Text _scopeDistanceText;
	[SerializeField]
	private Canvas _canvas;
}
