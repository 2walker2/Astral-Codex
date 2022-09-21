using UnityEngine;

public class ShipElectricalComponent : ShipComponent
{
	[SerializeField]
	protected ElectricalSystem _electricalSystem;
	[SerializeField]
	protected ShipLogController _shipLogController;
	[SerializeField]
	protected LandingCamera _landingCamera;
	[SerializeField]
	protected float _disruptionImpactSpeed;
	[SerializeField]
	protected float _disruptionLength;
	[SerializeField]
	private OWAudioSource _audioSource;
}
