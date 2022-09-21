using UnityEngine;
using System;

public class NomaiConversationManager : MonoBehaviour
{
	[Serializable]
	private struct StonePair
	{
		public NomaiWord wordA;
		public NomaiWord wordB;
		public NomaiWallText response;
	}

	[SerializeField]
	private SolanumAnimController _solanumAnimController;
	[SerializeField]
	private NomaiConversationStone[] _conversationStones;
	[SerializeField]
	private Animator _cairnAnimator;
	[SerializeField]
	private OWCollider _cairnCollision;
	[SerializeField]
	private NomaiConversationStoneSocket _stoneSocketA;
	[SerializeField]
	private NomaiConversationStoneSocket _stoneSocketB;
	[SerializeField]
	private OWTriggerVolume _watchPlayerVolume;
	[SerializeField]
	private CharacterDialogueTree _characterDialogueTree;
	[SerializeField]
	private StonePair[] _questions;
}
