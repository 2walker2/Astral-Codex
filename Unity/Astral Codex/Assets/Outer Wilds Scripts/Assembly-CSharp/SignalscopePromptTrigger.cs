using UnityEngine;

public class SignalscopePromptTrigger : MonoBehaviour
{
	[SerializeField]
	private bool _showPromptOnEnter;
	[SerializeField]
	private CharacterDialogueTree _dialogue;
	[SerializeField]
	private bool _switchFrequency;
	[SerializeField]
	private SignalFrequency _frequency;
}
