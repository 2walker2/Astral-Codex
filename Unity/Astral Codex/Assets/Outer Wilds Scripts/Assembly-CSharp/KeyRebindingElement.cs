using UnityEngine;
using UnityEngine.UI;

public class KeyRebindingElement : MenuOption
{
	[SerializeField]
	protected RebindableID _rebindID;
	[SerializeField]
	protected Button _controlButton;
	[SerializeField]
	protected SubmitAction _controlSubmitAction;
	[SerializeField]
	protected Button _labelButton;
	[SerializeField]
	protected GameObject _gamepadBindingImage1Obj;
	[SerializeField]
	protected GameObject _gamepadBindingImage2Obj;
	[SerializeField]
	protected Image _gamepadBindingImage1;
	[SerializeField]
	protected Image _gamepadBindingImage2;
	[SerializeField]
	protected GameObject _keyboardMouseBindingBlockObj;
	[SerializeField]
	protected GameObject _keyboardMouseBindingImage1Obj;
	[SerializeField]
	protected GameObject _keyboardMouseBindingImage2Obj;
	[SerializeField]
	protected Image _keyboardMouseBindingImage1;
	[SerializeField]
	protected Image _keyboardMouseBindingImage2;
}
