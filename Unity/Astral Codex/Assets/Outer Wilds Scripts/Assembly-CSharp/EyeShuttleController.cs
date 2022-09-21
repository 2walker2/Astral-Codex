using UnityEngine;

public class EyeShuttleController : MonoBehaviour
{
	[SerializeField]
	private GameObject _shuttleObject;
	[SerializeField]
	private EndlessCylinder _forestCylinder;
	[SerializeField]
	private EndlessTriggerVolume _endlessShuttleVolume;
	[SerializeField]
	private GameObject _blockExitObject;
	[SerializeField]
	private ParticleSystem _starParticles;
	[SerializeField]
	private ParticleSystem _slowParticles;
	[SerializeField]
	private GameObject _whiteSphere;
	[SerializeField]
	private GameObject _blackTunnel;
	[SerializeField]
	private GameObject _maskObject;
	[SerializeField]
	private Transform _playerMaskSocket;
	[SerializeField]
	private NomaiInterfaceSlot _launchSlot;
	[SerializeField]
	private NomaiInterfaceSlot _retrieveSlot;
	[SerializeField]
	private NomaiInterfaceSlot _landSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private OWTriggerVolume _shuttleVolume;
	[SerializeField]
	private OWTriggerVolume _beamResetVolume;
	[SerializeField]
	private TractorBeamController _tractorBeam;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
