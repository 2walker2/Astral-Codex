using UnityEngine;
using UnityEngine.UI;

public class DialogueOptionUI : MonoBehaviour
{
	[SerializeField]
	private LayoutElement _layoutElement;
	[SerializeField]
	private ContentSizeFitter _sizeFitter;
	[SerializeField]
	private Image _buttonPromptImage;
	[SerializeField]
	private Image _selectedOptionImage;
	[SerializeField]
	private Text _optionText;
}
