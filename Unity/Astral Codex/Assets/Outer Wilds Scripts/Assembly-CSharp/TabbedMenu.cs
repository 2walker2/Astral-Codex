using System;
using UnityEngine.UI;
using UnityEngine;

public class TabbedMenu : Menu
{
	[Serializable]
	public struct TabSelectablePair
	{
		public TabButton tabButton;
		public Selectable selectable;
	}

	[SerializeField]
	protected TabButton[] _menuTabs;
	[SerializeField]
	protected TabSelectablePair[] _tabSelectablePairs;
	[SerializeField]
	protected Image _tabLeftButtonImg;
	[SerializeField]
	protected Image _tabRightButtonImg;
}
