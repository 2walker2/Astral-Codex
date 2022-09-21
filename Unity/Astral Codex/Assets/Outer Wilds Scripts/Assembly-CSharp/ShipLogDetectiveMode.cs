using UnityEngine;

public class ShipLogDetectiveMode : ShipLogMode
{
	[SerializeField]
	private bool _editMode;
	[SerializeField]
	private RectTransform _rootCanvasTransform;
	[SerializeField]
	private CanvasGroupAnimator _canvasAnimator;
	[SerializeField]
	private RectTransform _scaleRoot;
	[SerializeField]
	private RectTransform _panRoot;
	[SerializeField]
	private RectTransform _reticle;
	[SerializeField]
	private ShipLogEntryDescriptionField _descriptionField;
	[SerializeField]
	private GameObject _entryCardTemplate;
	[SerializeField]
	private GameObject _entryLinkTemplate;
	[SerializeField]
	private ShipLogEntryHUDMarker _entryHUDMarker;
	[SerializeField]
	private OWAudioSource _navigateAudioSource;
	[SerializeField]
	private FontAndLanguageController _fontAndLanguageController;
}
