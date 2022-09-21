using UnityEngine;
using System;

public class RemoteDialogueTrigger : MonoBehaviour
{
	[Serializable]
	public struct RemoteDialogueCondition
	{
		public int priority;
		public CharacterDialogueTree dialogue;
		public RemoteDialogueTrigger.MultiConditionType prereqConditionType;
		public string[] prereqConditions;
		public string[] onTriggerEnterConditions;
	}

	public enum MultiConditionType
	{
		OR = 0,
		AND = 1,
	}

	[SerializeField]
	private RemoteDialogueCondition[] _listDialogues;
	[SerializeField]
	private bool _deactivateTriggerPostConversation;
}
