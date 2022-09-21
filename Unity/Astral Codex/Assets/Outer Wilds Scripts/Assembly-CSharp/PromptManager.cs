using UnityEngine;

public class PromptManager : MonoBehaviour
{
	[SerializeField]
	private Font _font;
	[SerializeField]
	private int _fontSize;
	[SerializeField]
	private float _promptElementMinWidth;
	[SerializeField]
	private float _promptElementMinHeight;
	[SerializeField]
	private ScreenPromptList _bottomLeftList;
	[SerializeField]
	private ScreenPromptList _centerList;
	[SerializeField]
	private ScreenPromptList _topRightList;
	[SerializeField]
	private ScreenPromptList _topLeftList;
	[SerializeField]
	private ScreenPromptList _bottomCenterList;
	[SerializeField]
	private ScreenPromptList _boostPromptList;
}
