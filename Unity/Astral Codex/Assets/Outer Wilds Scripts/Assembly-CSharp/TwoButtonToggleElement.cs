using UnityEngine.UI;
using UnityEngine;

public class TwoButtonToggleElement : ToggleElement
{
	[SerializeField]
	private Button _buttonTrue;
	[SerializeField]
	private Button _buttonFalse;
	[SerializeField]
	private Selectable[] _colorDependentSelectables;
	[SerializeField]
	private Graphic[] _colorDependentGraphics;
}
