using UnityEngine;

public class ShipCockpitUI : MonoBehaviour
{
	[SerializeField]
	private GameObject _shipBodyRoot;
	[SerializeField]
	private ShipCockpitController _shipSystemsCtrlr;
	[SerializeField]
	private ShipNotificationDisplay _shipConsole;
	[SerializeField]
	private Transform _probeLauncherDisplay;
	[SerializeField]
	private Transform _probeLauncherStowRotation;
	[SerializeField]
	private Transform _probeLauncherDisplayRotation;
	[SerializeField]
	private ShipLight _probeLauncherScreenLight;
	[SerializeField]
	private float _probeRotateTime;
	[SerializeField]
	private SignalscopeUI _signalscopeUI;
	[SerializeField]
	private float _screenEmissionOff;
	[SerializeField]
	private ShipLight _sigScopeScreenLight;
	[SerializeField]
	private Transform _sigScopeDisplay;
	[SerializeField]
	private Transform _sigScopeStowRotation;
	[SerializeField]
	private Transform _sigScopeDisplayRotation;
	[SerializeField]
	private Transform _sigScopeDish;
	[SerializeField]
	private float _scopeRotateTime;
	[SerializeField]
	private MeshRenderer _scopeMeshRenderer;
	[SerializeField]
	private float _screenEmissionConsole;
	[SerializeField]
	private MeshRenderer _consoleScreenMeshRndr;
	[SerializeField]
	private Light _damageLight;
	[SerializeField]
	private ShipLight _damageScreenLight;
	[SerializeField]
	private MeshRenderer _damageLightMeshRndr;
	[SerializeField]
	private int _damageLightMatIndex;
	[SerializeField]
	private Light _flashlightlightFLL;
	[SerializeField]
	private MeshRenderer _fllMeshRndr;
	[SerializeField]
	private Light _autopilotLight;
	[SerializeField]
	private MeshRenderer _autopilotLightMeshRndr;
	[SerializeField]
	private Light _matchingVelocityLight;
	[SerializeField]
	private MeshRenderer _matchVMeshRndr;
	[SerializeField]
	private ReferenceFrameGUI _cockpitLockOnGui;
	[SerializeField]
	private float _lockOnGuiPlaneDistance;
	[SerializeField]
	private ShipLight _landingCamScreenLight;
	[SerializeField]
	private ShipLight _altimeterLight;
	[SerializeField]
	private ShipLight _minimapLight;
	[SerializeField]
	private ShipLight _minimapNorthPoleLight;
	[SerializeField]
	private ShipLight _minimapSouthPoleLight;
	[SerializeField]
	private ShipLight _minimapProbeLight;
	[SerializeField]
	private ShipLight _minimapShipLight;
}
