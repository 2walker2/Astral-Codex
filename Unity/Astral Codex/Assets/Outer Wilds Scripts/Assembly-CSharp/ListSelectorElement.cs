using UnityEngine.UI;
using UnityEngine;

public class ListSelectorElement : OptionsSelectorElement
{
	[SerializeField]
	protected LayoutElement _wholeControlLayoutElement;
	[SerializeField]
	protected HorizontalLayoutGroup _wholeElementHorzLayoutGroup;
	[SerializeField]
	protected LayoutElement _listSectionLayoutElement;
	[SerializeField]
	protected ToggleElement _templateToggle;
	[SerializeField]
	protected VerticalLayoutGroup _toggleListLayoutGroup;
}
