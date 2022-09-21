using UnityEngine;
using UnityEngine.UI;

public class TabbedNavigation : MonoBehaviour
{
	[SerializeField]
	protected bool _enableOnlyWhenOnKeyboard;
	[SerializeField]
	protected Selectable _tabForwardSelectable;
	[SerializeField]
	protected Selectable _tabBackwardSelectable;
}
