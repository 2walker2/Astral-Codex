using UnityEngine.UI;
using UnityEngine;

public class TwoButtonActionElement : MenuOption
{
	private enum ElementSelectables
	{
		UNDEFINED = -1,
		BUTTON_ONE = 1,
		BUTTON_TWO = 0,
	}

	[SerializeField]
	private Button _buttonOne;
	[SerializeField]
	private Button _buttonTwo;
	[SerializeField]
	private ElementSelectables _selectButtonOnElementSelect;
	[SerializeField]
	private SubmitAction _submitActionOne;
	[SerializeField]
	private SubmitAction _submitActionTwo;
	[SerializeField]
	private Selectable[] _colorDependentSelectables;
	[SerializeField]
	private Graphic[] _colorDependentGraphics;
}
