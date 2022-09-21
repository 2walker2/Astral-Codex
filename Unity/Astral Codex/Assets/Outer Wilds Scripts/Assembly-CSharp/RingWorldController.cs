using UnityEngine;

public class RingWorldController : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _ringWorldBody;
	[SerializeField]
	private OWRigidbody _staticRingBody;
	[SerializeField]
	private OWTriggerVolume[] _enterOnWakeVolumes;
	[SerializeField]
	private OWTriggerVolume _insideRingWorldVolume;
	[SerializeField]
	private RingRiverController _riverController;
	[SerializeField]
	private RingRiverPathAudioController _riverPathAudioController;
	[SerializeField]
	private float _sailDeployTime;
	[SerializeField]
	private float _lightFlickerTime;
	[SerializeField]
	private float _departTime;
	[SerializeField]
	private float _damDamageTime;
	[SerializeField]
	private float _damBreakTime;
	[SerializeField]
	private float _lighthouseCollapseTime;
	[SerializeField]
	private Animation[] _solarSailAnimations;
	[SerializeField]
	private OWCollider _solarSailClosedCollider;
	[SerializeField]
	private OWCollider _solarSailOpenCollider;
	[SerializeField]
	private GameObject _solarSailClosedProxy;
	[SerializeField]
	private GameObject _solarSailOpenProxy;
	[SerializeField]
	private float _sailDeployDuration;
	[SerializeField]
	private Vector3 _departDirection;
	[SerializeField]
	private float _departAcceleration;
	[SerializeField]
	private float _interiorAccelFactor;
	[SerializeField]
	private RingWorldFlickerController _flickerController;
	[SerializeField]
	private RingWorldScreenController _screenController;
	[SerializeField]
	private DamDestructionController _damController;
	[SerializeField]
	private LighthouseController _lighthouseController;
	[SerializeField]
	private OWTriggerVolume _zone1TriggerVolume;
	[SerializeField]
	private float _damLifeExtendDuration;
	[SerializeField]
	private OWAudioSource _solarSailOneShot;
	[SerializeField]
	private OWAudioSource _solarSailLooping;
	[SerializeField]
	private OWAudioSource _flickerOneShot;
	[SerializeField]
	private OWAudioSource _damOneShotAudio_Far;
}
