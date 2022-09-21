using UnityEngine.UI;
using UnityEngine;

public class PopupMenu : Menu
{
	[SerializeField]
	protected Text _labelText;
	[SerializeField]
	protected SubmitAction _cancelAction;
	[SerializeField]
	protected SubmitAction _okAction;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _cancelButton;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _confirmButton;
	[SerializeField]
	protected Canvas _rootCanvas;
}
