using UnityEngine;

public class NomaiShuttleController : MonoBehaviour
{
	public enum ShuttleID
	{
		HourglassShuttle = 0,
		BrittleHollowShuttle = 1,
	}

	[SerializeField]
	private ShuttleID _id;
	[SerializeField]
	private float _retrievalLength;
	[SerializeField]
	private NomaiInterfaceSlot _launchSlot;
	[SerializeField]
	private NomaiInterfaceSlot _retrieveSlot;
	[SerializeField]
	private NomaiInterfaceSlot _landSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private OWTriggerVolume _beamResetVolume;
	[SerializeField]
	private TractorBeamController _tractorBeam;
	[SerializeField]
	private OWRigidbody _shuttleBody;
	[SerializeField]
	private GameObject _detectorObj;
	[SerializeField]
	private ForceVolume _forceVolume;
	[SerializeField]
	private GameObject _exteriorColliderRoot;
	[SerializeField]
	private CollisionGroup _exteriorCollisionGroup;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private GameObject _landingBeamRoot;
	[SerializeField]
	private GameObject _exteriorRendererObj;
}
