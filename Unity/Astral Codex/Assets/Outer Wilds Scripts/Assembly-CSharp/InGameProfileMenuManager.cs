using UnityEngine;
using UnityEngine.UI;

public class InGameProfileMenuManager : MonoBehaviour
{
	[SerializeField]
	private Menu _onDisconnectPauseMenu;
	[SerializeField]
	private Text _messageText;
	[SerializeField]
	private SubmitActionCloseMenu _returnToGameSubmitAction;
	[SerializeField]
	private SubmitActionLoadScene _returnToTitleSubmitAction;
	[SerializeField]
	private JoystickListener _returnToGameJoystickListener;
	[SerializeField]
	private Button _returnToGameButton;
	[SerializeField]
	private Button _signInButton;
	[SerializeField]
	private Button _exitToMainMenu;
}
