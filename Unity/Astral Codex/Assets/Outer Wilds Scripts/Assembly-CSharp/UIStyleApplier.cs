using UnityEngine;
using System;
using UnityEngine.UI;

public class UIStyleApplier : MonoBehaviour
{
	[Serializable]
	public struct OnOffGraphic
	{
		public Graphic graphic;
		public bool visibleNormal;
		public bool visibleIntermediate;
		public bool visibleHighlighted;
		public bool visiblePressed;
		public bool visibleDisabled;
		public bool visibleMouseRollover;
	}

	[SerializeField]
	protected bool _secondaryMenuItem;
	[SerializeField]
	protected bool _buttonItem;
	[SerializeField]
	protected bool _preflightItem;
	[SerializeField]
	protected Text[] _textItems;
	[SerializeField]
	protected Graphic[] _foregroundGraphics;
	[SerializeField]
	protected Graphic[] _backgroundGraphics;
	[SerializeField]
	protected Graphic[] _onOffGraphics;
	[SerializeField]
	protected OnOffGraphic[] _onOffGraphicList;
}
