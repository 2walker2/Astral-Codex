using UnityEngine;

public class FloodParticleToggle : SectoredMonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private ParticleSystem[] _particles;
	[SerializeField]
	private bool _playAfterFlood;
}
