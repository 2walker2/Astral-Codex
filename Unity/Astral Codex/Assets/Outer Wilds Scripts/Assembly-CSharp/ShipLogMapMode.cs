using UnityEngine;
using UnityEngine.UI;

public class ShipLogMapMode : ShipLogMode
{
	[SerializeField]
	private ShipLogAstroObject[] _topRow;
	[SerializeField]
	private ShipLogAstroObject[] _midRow;
	[SerializeField]
	private ShipLogAstroObject[] _bottomRow;
	[SerializeField]
	private ShipLogSandFunnel _sandFunnel;
	[SerializeField]
	private RectTransform _scaleRoot;
	[SerializeField]
	private RectTransform _panRoot;
	[SerializeField]
	private RectTransform _entryListRoot;
	[SerializeField]
	private GameObject _entryTemplate;
	[SerializeField]
	private ShipLogEntryDescriptionField _descriptionField;
	[SerializeField]
	private Text _nameField;
	[SerializeField]
	private RectTransform _photoRoot;
	[SerializeField]
	private Image _photo;
	[SerializeField]
	private Text _questionMark;
	[SerializeField]
	private RectTransform _entrySelectArrow;
	[SerializeField]
	private CanvasGroupAnimator _mapModeAnimator;
	[SerializeField]
	private CanvasGroupAnimator _solarSystemAnimator;
	[SerializeField]
	private CanvasGroupAnimator _entryMenuAnimator;
	[SerializeField]
	private CanvasGroupAnimator _reticleAnimator;
	[SerializeField]
	private ShipLogEntryHUDMarker _entryHUDMarker;
	[SerializeField]
	private GameObject _markOnHUDPromptRoot;
	[SerializeField]
	private ScreenPromptList _markHUDPromptList;
	[SerializeField]
	private FontAndLanguageController _fontAndLanguageController;
}
