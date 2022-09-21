using UnityEngine;
using UnityEngine.UI;

public class ProfileMenuManager : MonoBehaviour
{
	[SerializeField]
	private Menu _profileMenu;
	[SerializeField]
	private Text _currenProfileLabel;
	[SerializeField]
	private Button _createProfileButton;
	[SerializeField]
	private PopupMenu _createProfileConfirmPopup;
	[SerializeField]
	private GameObject _profileListRoot;
	[SerializeField]
	private GameObject _profileItemTemplate;
	[SerializeField]
	private RectTransform _profileListScrollViewContent;
	[SerializeField]
	private FontAndLanguageController _fontController;
	[SerializeField]
	private ButtonWithHotkeyImageElement _closeMenuButton;
}
