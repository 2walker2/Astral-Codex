using UnityEngine;

public class PopupTwoOptionMenu : Menu
{
	[SerializeField]
	protected SubmitAction _actionOne;
	[SerializeField]
	protected SubmitAction _actionTwo;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _buttonOne;
	[SerializeField]
	protected ButtonWithHotkeyImageElement _buttonTwo;
	[SerializeField]
	protected Canvas _rootCanvas;
}
