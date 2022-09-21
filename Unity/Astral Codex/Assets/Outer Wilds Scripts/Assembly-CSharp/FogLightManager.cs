using UnityEngine;

public class FogLightManager : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Sprite _fogLightSprite;
	[SerializeField]
	private GameObject _templateImageObject;
	[SerializeField]
	private bool _useDebugSprite;
	[SerializeField]
	private Sprite _debugSprite;
	[SerializeField]
	private bool _onGUIMode;
}
