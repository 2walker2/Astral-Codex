using UnityEngine;

public class ElectricityVolume : HazardVolume
{
	[SerializeField]
	private float _shockRepeatTime;
	[SerializeField]
	private float _kickback;
	[SerializeField]
	private bool _shellKickback;
	[SerializeField]
	private float _shellThickness;
	[SerializeField]
	private OWAudioSource[] _shockAudioPool;
}
