using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
	[SerializeField]
	private Menu _pauseMenu;
	[SerializeField]
	private GameObject _skipToNextLoopButton;
	[SerializeField]
	private SubmitAction _endCurrentLoopAction;
	[SerializeField]
	private SubmitAction _exitToMainMenuAction;
}
