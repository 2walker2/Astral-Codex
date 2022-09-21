using UnityEngine;

public class ShipLogEntryDescriptionField : MonoBehaviour
{
	[SerializeField]
	private GameObject _factItemTemplate;
	[SerializeField]
	private RectTransform _listRoot;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private ScreenPromptList _scrollPromptList;
	[SerializeField]
	private GameObject _scrollPromptRoot;
	[SerializeField]
	private FontAndLanguageController _fontAndLanguageController;
}
