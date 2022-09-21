using UnityEngine;

public class MuseumDialogueSwapper : MonoBehaviour
{
	[SerializeField]
	private CharacterDialogueTree _dialogue;
	[SerializeField]
	private TextAsset _xmlToSwapWith;
	[SerializeField]
	private string _LogID;
}
