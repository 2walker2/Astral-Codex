using UnityEngine;
using UnityEngine.UI;

public class ButtonWithHotkeyImageElement : MonoBehaviour
{
	[SerializeField]
	private Text _buttonText;
	[SerializeField]
	private Image _buttonBorderImage;
	[SerializeField]
	private Image _hotkeyImageOne;
	[SerializeField]
	private Image _hotkeyImageTwo;
	[SerializeField]
	private GameObject _imageOneLayoutObject;
	[SerializeField]
	private GameObject _imageTwoLayoutObject;
	[SerializeField]
	private RectTransform _graphicElementsRootTransform;
	[SerializeField]
	private LayoutElement _hotkeyImageOneLayoutElement;
	[SerializeField]
	private LayoutElement _hotkeyImageTwoLayoutElement;
	[SerializeField]
	private LayoutElement _spacerElement;
	[SerializeField]
	private float _imageToTextElementSpacing;
}
