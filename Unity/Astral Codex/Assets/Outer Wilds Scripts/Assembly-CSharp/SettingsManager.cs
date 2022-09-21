using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
	[SerializeField]
	private TabbedMenu _mainSettingsMenu;
	[SerializeField]
	private SubmitAction _resetSettingsActionByCommand;
	[SerializeField]
	private SubmitAction _resetSettingsAction;
	[SerializeField]
	private SubmitAction _closeMenuAction;
	[SerializeField]
	private ButtonWithHotkeyImageElement _resetSettingsFooterButton;
	[SerializeField]
	private ButtonWithHotkeyImageElement _closeMenuFooterButton;
	[SerializeField]
	private Menu _gameplayMenu;
	[SerializeField]
	private Menu _subGameplayMenu;
	[SerializeField]
	private Menu _subGameplayMenu2;
	[SerializeField]
	private MenuOption[] _listGameplayOptions;
	[SerializeField]
	private MenuOption[] _listGameplayOptions2;
	[SerializeField]
	private MenuOption _toggleBoost;
	[SerializeField]
	private MenuOption _toggleTranslatorEquip;
	[SerializeField]
	private MenuOption _toggleShipLogNotifications;
	[SerializeField]
	private MenuOption _toggleArcheologistMode;
	[SerializeField]
	private MenuOption _toggleAutopilot;
	[SerializeField]
	private MenuOption _toggleButtonPrompts;
	[SerializeField]
	private Menu _textAudioMenu;
	[SerializeField]
	private MenuOption[] _listAudioLangOptions;
	[SerializeField]
	private SliderElement _sliderMasterVol;
	[SerializeField]
	private SliderElement _sliderMusicVol;
	[SerializeField]
	private OptionsSelectorElement _optionsTextSpeed;
	[SerializeField]
	private TwoButtonToggleElement _toggleReadFreezeTimeTranslator;
	[SerializeField]
	private TwoButtonToggleElement _toggleReadFreezeTimeShipLog;
	[SerializeField]
	private TwoButtonToggleElement _toggleReadFreezeTimeConversation;
	[SerializeField]
	private OptionsSelectorElement _optionsLanguage;
	[SerializeField]
	private Menu _inputMenu;
	[SerializeField]
	private MenuOption[] _listControlOptions;
	[SerializeField]
	private TwoButtonToggleElement _toggleInvertPlayer;
	[SerializeField]
	private TwoButtonToggleElement _toggleInvertShip;
	[SerializeField]
	private TwoButtonToggleElement _toggleRumble;
	[SerializeField]
	private SliderElement _sliderLookSensitivity;
	[SerializeField]
	private SliderElement _sliderFlightSensitivity;
	[SerializeField]
	private SliderElement _sliderInnerDeadZone;
	[SerializeField]
	private SliderElement _sliderOuterDeadZone;
	[SerializeField]
	private Button _buttonRemapControls;
	[SerializeField]
	private Menu _graphicsMenu;
	[SerializeField]
	private MenuOption[] _listGraphicsOptions;
	[SerializeField]
	private OptionsSelectorElement _optionsPresets;
	[SerializeField]
	private TwoButtonToggleElement _toggleFullScreen;
	[SerializeField]
	private OptionsSelectorElement _optionsMonitor;
	[SerializeField]
	private OptionsSelectorElement _optionsAspectRatio;
	[SerializeField]
	private OptionsSelectorElement _optionsResolution;
	[SerializeField]
	private OptionsSelectorElement _optionsAntiAliasType;
	[SerializeField]
	private OptionsSelectorElement _optionsAntiAliasQual;
	[SerializeField]
	private OptionsSelectorElement _optionsTextureQual;
	[SerializeField]
	private OptionsSelectorElement _optionsShadowQual;
	[SerializeField]
	private OptionsSelectorElement _optionsAmbOcclQual;
	[SerializeField]
	private OptionsSelectorElement _optionsOceanQual;
	[SerializeField]
	private TwoButtonToggleElement _toggleVSync;
	[SerializeField]
	private SliderElement _sliderFOV;
	[SerializeField]
	private SliderElement _sliderGamma;
	[SerializeField]
	private SliderElement _sliderDithering;
	[SerializeField]
	private Text _textDisplayFOV;
	[SerializeField]
	private Text _textDisplayGamma;
}
