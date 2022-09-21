using UnityEngine;

public class CharacterDialogueTree : MonoBehaviour
{
	[SerializeField]
	private TextAsset _xmlCharacterDialogueAsset;
	[SerializeField]
	private Transform _attentionPoint;
	[SerializeField]
	private Vector3 _attentionPointOffset;
	[SerializeField]
	private bool _turnOffFlashlight;
	[SerializeField]
	private bool _turnOnFlashlight;
}
