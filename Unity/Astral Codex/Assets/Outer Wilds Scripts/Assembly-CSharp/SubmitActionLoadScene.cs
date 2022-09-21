using UnityEngine;
using UnityEngine.UI;

public class SubmitActionLoadScene : SubmitActionConfirm
{
	public enum LoadableScenes
	{
		GAME = 0,
		EYE = 1,
		TITLE = 2,
		CREDITS = 3,
	}

	[SerializeField]
	private LoadableScenes _sceneToLoad;
	[SerializeField]
	protected Text _loadingText;
	[SerializeField]
	private TitleScreenStreaming _titleScreenStreaming;
}
