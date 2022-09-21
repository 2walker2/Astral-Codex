using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class FontAndLanguageController : MonoBehaviour
{
	[Serializable]
	protected class TextItemsRootObject
	{
		public GameObject rootObj;
		public GameObject[] excludeObj;
		public bool controlScale;
		public bool useDefaultLineSpacing;
		public bool isLanguageFont;
	}

	[Serializable]
	protected class TextItem
	{
		public Text textElement;
		public bool controlScale;
		public bool useDefaultLineSpacing;
		public bool isLanguageFont;
	}

	[SerializeField]
	protected List<FontAndLanguageController.TextItemsRootObject> _rootObjectsWithTextList;
	[SerializeField]
	protected List<FontAndLanguageController.TextItem> _textItemList;
}
