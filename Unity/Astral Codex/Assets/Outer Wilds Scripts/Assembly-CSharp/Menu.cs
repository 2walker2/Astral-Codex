using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	[SerializeField]
	protected GameObject _menuActivationRoot;
	[SerializeField]
	protected bool _startEnabled;
	[SerializeField]
	protected Selectable _selectOnActivate;
	[SerializeField]
	protected GameObject _selectableItemsRoot;
	[SerializeField]
	protected Menu[] _subMenus;
	[SerializeField]
	protected MenuOption[] _menuOptions;
	[SerializeField]
	protected bool _setMenuNavigationOnActivate;
	[SerializeField]
	protected TooltipDisplay _tooltipDisplay;
	[SerializeField]
	protected bool _addToMenuStackManager;
}
