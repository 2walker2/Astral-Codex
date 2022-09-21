using UnityEngine;
using UnityEngine.UI;

public class NomaiTranslatorProp : MonoBehaviour
{
	[SerializeField]
	private GameObject _translatorProp;
	[SerializeField]
	private MeshRenderer _leftPageArrowRenderer;
	[SerializeField]
	private MeshRenderer _rightPageArrowRenderer;
	[SerializeField]
	private Font _defaultPropFont;
	[SerializeField]
	private Font _defaultPropFontDynamic;
	[SerializeField]
	private float _defaultFontSpacing;
	[SerializeField]
	private Text _textField;
	[SerializeField]
	private Text _pageNumberTextField;
}
