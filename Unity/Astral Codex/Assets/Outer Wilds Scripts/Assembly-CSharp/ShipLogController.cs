using UnityEngine;

public class ShipLogController : MonoBehaviour
{
	[SerializeField]
	private Canvas _shipLogCanvas;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private Transform _lockOnPoint;
	[SerializeField]
	private SingleInteractionVolume _interactVolume;
	[SerializeField]
	private ShipLogMode _detectiveMode;
	[SerializeField]
	private ShipLogMode _mapMode;
	[SerializeField]
	private ShipLogSplashScreen _splashScreen;
	[SerializeField]
	private ScreenPromptList _upperRightPromptList;
	[SerializeField]
	private ScreenPromptList _centerPromptList;
	[SerializeField]
	private OWAudioSource _ambienceSource;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
