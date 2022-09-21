using UnityEngine;

public class PrisonerChoiceDialogue : MonoBehaviour
{
	[SerializeField]
	private QuantumCampsiteController _campsiteController;
	[SerializeField]
	private QuantumInstrument _instrument;
	[SerializeField]
	private CharacterDialogueTree _dialogueTree;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private VisibilityObject _choiceVisibilityObject;
	[SerializeField]
	private VisibilityObject _campfireVisibilityObject;
	[SerializeField]
	private GameObject _choicePrisonerRoot;
	[SerializeField]
	private GameObject _campfirePrisonerRoot;
}
