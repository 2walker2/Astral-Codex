using UnityEngine;
using UnityEngine.UI;

public class ShipLogEntryListItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform _animRoot;
	[SerializeField]
	private RectTransform _iconRoot;
	[SerializeField]
	private RectTransform _selectionArrowAnchor;
	[SerializeField]
	private LayoutElement _indentationElement;
	[SerializeField]
	private CanvasRenderer _borderLine;
	[SerializeField]
	private Text _nameField;
	[SerializeField]
	private Image _unreadIcon;
	[SerializeField]
	private Image _hudMarkerIcon;
	[SerializeField]
	private Image _moreToExploreIcon;
	[SerializeField]
	private int _entryFontSize;
	[SerializeField]
	private int _subEntryFontSize;
}
