using UnityEngine;

public class VesselWarpController : MonoBehaviour
{
	[SerializeField]
	private SingularityController _blackHole;
	[SerializeField]
	private SingularityController _whiteHole;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private WarpCoreSocket _coreSocket;
	[SerializeField]
	private DirectionalForceVolume _gravityVolume;
	[SerializeField]
	private OWTriggerVolume _bridgeVolume;
	[SerializeField]
	private TransformAnimator _cageAnimator;
	[SerializeField]
	private OWTriggerVolume _cageTrigger;
	[SerializeField]
	private OWAudioSource _cageLoopingAudio;
	[SerializeField]
	private NomaiCoordinateInterface _coordinateInterface;
	[SerializeField]
	private NomaiWarpPlatform _sourceWarpPlatform;
	[SerializeField]
	private NomaiWarpPlatform _targetWarpPlatform;
	[SerializeField]
	private NomaiInterfaceSlot _coordinatePowerSlot;
	[SerializeField]
	private NomaiInterfaceSlot _warpPlatformPowerSlot;
	[SerializeField]
	private NomaiInterfaceSlot _warpVesselSlot;
	[SerializeField]
	private NomaiEnergyCable _coordinateCable;
	[SerializeField]
	private NomaiEnergyCable _warpPlatformCable;
	[SerializeField]
	private NomaiEnergyCable _coreCable;
	[SerializeField]
	private OWAudioSource _blackHoleOneShot;
	[SerializeField]
	private OWAudioSource _whiteHoleOneShot;
	[SerializeField]
	private Transform _defaultPlayerWarpPoint;
}
