using UnityEngine;

public class TravelerController : SectoredMonoBehaviour
{
	[SerializeField]
	protected CharacterDialogueTree _dialogueSystem;
	[SerializeField]
	protected Animator _animator;
	[SerializeField]
	protected AudioSource _audioSource;
	[SerializeField]
	protected float _delayToRestartAudio;
	[SerializeField]
	private VoidShadowEffectController _voidShadowEffect;
}
