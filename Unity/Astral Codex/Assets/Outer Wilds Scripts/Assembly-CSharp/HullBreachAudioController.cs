using UnityEngine;

public class HullBreachAudioController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _rushingAirVolume;
	[SerializeField]
	private AbstractGhostDoorInterface _interface;
	[SerializeField]
	private RotatingDoor _door;
	[SerializeField]
	private OWAudioSource _loopingSource;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
