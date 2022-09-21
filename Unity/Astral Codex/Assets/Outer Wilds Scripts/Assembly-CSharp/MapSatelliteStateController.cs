using UnityEngine;

public class MapSatelliteStateController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _velocityNominalChange;
	[SerializeField]
	private float _impactSpeedLimit;
	[SerializeField]
	private InitialMotion _motionController;
	[SerializeField]
	private AlignWithTargetBody _alignScript;
	[SerializeField]
	private GameObject[] _damagedEffects;
	[SerializeField]
	private LightFlicker _lightFlicker;
}
