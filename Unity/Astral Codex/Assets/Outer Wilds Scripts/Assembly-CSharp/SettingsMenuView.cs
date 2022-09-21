using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : MonoBehaviour
{
	[SerializeField]
	private SettingsMenuModel _model;
	[SerializeField]
	private TabbedMenu _mainSettingsMenu;
	[SerializeField]
	private Menu _gameplayMenu;
	[SerializeField]
	private Menu _audioLangMenu;
	[SerializeField]
	private Menu _controlsMenu;
	[SerializeField]
	private Menu _graphicsMenu;
	[SerializeField]
	private MenuConfirmCancelAction _confirmCancelAction;
	[SerializeField]
	private MenuOption[] _listSettingsOptions;
	[SerializeField]
	private MenuValueOption[] _listGraphicsSettingsOptions;
	[SerializeField]
	private MenuValueOption _confirmToggleOption;
	[SerializeField]
	private KeyRebindingElement[] _listRebindableOptions;
	[SerializeField]
	private ButtonWithHotkeyImageElement _resetToDefaultButton;
	[SerializeField]
	private ButtonWithHotkeyImageElement _closeMenuButton;
	[SerializeField]
	private ButtonWithHotkeyImageElement _cancelRebindingButton;
	[SerializeField]
	private InputEventListener _cancelRebindingButtonListener;
	[SerializeField]
	private SubmitAction _resetSettingsActionByCommand;
	[SerializeField]
	private SubmitAction _resetSettingsAction;
	[SerializeField]
	private SubmitAction _closeMenuAction;
	[SerializeField]
	private Image _consoleConfirmOptionImgOne;
	[SerializeField]
	private Image _consoleConfirmOptionImgTwo;
	[SerializeField]
	private GameObject _raycastBlocker;
}
