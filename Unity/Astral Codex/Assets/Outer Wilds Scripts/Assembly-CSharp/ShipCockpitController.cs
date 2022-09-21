using UnityEngine;

public class ShipCockpitController : MonoBehaviour
{
	[SerializeField]
	private ShipLight _headlight;
	[SerializeField]
	private ShipLight _landingLight;
	[SerializeField]
	private ShipLight[] _dimmingLights;
	[SerializeField]
	private float _dimmingLightScale;
	[SerializeField]
	private ProbeLauncher _shipProbeLauncher;
	[SerializeField]
	private PlayerAttachPoint _playerAttachPoint;
	[SerializeField]
	private Collider _cockpitCollider;
	[SerializeField]
	private Collider[] _fogLightOcclusionColliders;
	[SerializeField]
	private ShipCanvasGroup[] _shipCanvases;
	[SerializeField]
	private ShipCanvasGroup[] _dashboardCanvases;
	[SerializeField]
	private LandingCamera _landingCam;
}
