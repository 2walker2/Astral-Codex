using UnityEngine;

public class TravelerEyeController : MonoBehaviour
{
	[SerializeField]
	private CharacterDialogueTree _dialogueTree;
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private Animator _rockingChairAnimator;
	[SerializeField]
	private AudioSignal _signal;
	[SerializeField]
	private string _startPlayingCondition;
}
