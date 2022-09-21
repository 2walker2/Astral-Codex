using UnityEngine;

public class RapidsHazardVolume : HazardVolume
{
	[SerializeField]
	private float _minTorqueDelay;
	[SerializeField]
	private float _maxTorqueDelay;
	[SerializeField]
	private float _torqueAcceleration;
	[SerializeField]
	private float _minTorqueDuration;
	[SerializeField]
	private float _maxTorqueDuration;
}
