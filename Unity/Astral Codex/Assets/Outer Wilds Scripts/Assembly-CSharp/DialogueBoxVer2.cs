using UnityEngine;
using UnityEngine.UI;

public class DialogueBoxVer2 : MonoBehaviour
{
	[SerializeField]
	private LayoutGroup _mainLayoutRoot;
	[SerializeField]
	private Text _mainTextField;
	[SerializeField]
	private Text _nameTextField;
	[SerializeField]
	private GameObject _nameBox;
	[SerializeField]
	private GameObject _optionBox;
	[SerializeField]
	private LayoutGroup _optionsLayoutRoot;
	[SerializeField]
	private bool _turnOnNameField;
	[SerializeField]
	private GameObject _buttonPromptElement;
	[SerializeField]
	private Image _continueSprite;
	[SerializeField]
	private RectTransform _backgroundImageTransform;
	[SerializeField]
	private float _backgroundImageTopBottomMargin;
	[SerializeField]
	private float _backgroundImageLeftRightMargin;
	[SerializeField]
	private Font _defaultDialogueFont;
	[SerializeField]
	private Font _defaultDialogueFontDynamic;
	[SerializeField]
	private float _defaultFontSpacing;
}
