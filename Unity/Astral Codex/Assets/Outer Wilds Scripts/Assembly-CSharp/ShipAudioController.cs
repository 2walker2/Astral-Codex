using UnityEngine;

public class ShipAudioController : MonoBehaviour
{
	[SerializeField]
	private ShipElectricalComponent _shipElectrics;
	[SerializeField]
	private OWAudioSource _alarmSource;
	[SerializeField]
	private OWAudioSource _ambientSource;
	[SerializeField]
	private OWAudioSource _fluidVolumeSource;
	[SerializeField]
	private OWAudioSource _loudShipSource;
	[SerializeField]
	private OWAudioSource _hatchSource;
	[SerializeField]
	private OWAudioSource _cockpitSource;
	[SerializeField]
	private OWAudioSource _glassCrackSource;
	[SerializeField]
	private OWAudioSource _probeScreenSource;
	[SerializeField]
	private OWAudioSource _signalscopeSource;
	[SerializeField]
	private OWAudioSource _cockpitInstrumentsAudioSource;
	[SerializeField]
	private OWAudioSource _cockpitInstrumentsAudioSource2;
	[SerializeField]
	private OWAudioSource _ejectCoverSource;
	[SerializeField]
	private OWAudioSource[] _hullImpactSources;
}
