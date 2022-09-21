using UnityEngine;
using UnityEngine.UI;

public class MultiSelectionListElement : MenuOption
{
	[SerializeField]
	protected UIStyleApplier _optionsBoxStyleApplier;
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
