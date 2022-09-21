using UnityEngine;

public class MenuConfirmCancelAction : MenuCancelAction
{
	[SerializeField]
	protected PopupMenu _confirmPopup;
	[SerializeField]
	protected UITextType _confirmMessage;
}
