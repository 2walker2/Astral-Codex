using UnityEngine;
using UnityEngine.UI;

public class MenuOption : MonoBehaviour
{
	[SerializeField]
	protected SettingsID _settingId;
	[SerializeField]
	protected Text _label;
	[SerializeField]
	protected Text _secondaryTextField;
	[SerializeField]
	protected UITextType _tooltipTextType;
	[SerializeField]
	protected string _overrideTooltipText;
	[SerializeField]
	private bool _enableXbox;
	[SerializeField]
	private bool _enablePS4;
	[SerializeField]
	private bool _enablePC;
	[SerializeField]
	private bool _enableInGame;
	[SerializeField]
	private bool _dlcOnly;
}
