using UnityEngine.UI;
using UnityEngine;

public class ToggleElement : MenuValueOption
{
	[SerializeField]
	private Text _displayText;
	[SerializeField]
	private Graphic _toggleGraphic;
	[SerializeField]
	private Button _toggleElementButton;
	[SerializeField]
	private bool _isPreflightChecklist;
}
