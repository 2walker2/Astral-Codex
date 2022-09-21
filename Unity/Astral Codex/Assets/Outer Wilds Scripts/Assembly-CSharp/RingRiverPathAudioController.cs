using UnityEngine;

public class RingRiverPathAudioController : RiverPathAudioController
{
	[SerializeField]
	private RiverPathAudioSource _riverSource;
	[SerializeField]
	private RiverPathAudioSource _reservoirSource;
	[SerializeField]
	private RiverPathAudioSource _coveSource;
	[SerializeField]
	private OWTriggerVolume[] _coveVolumes;
	[SerializeField]
	private float _startReservoirDegrees;
}
