using UnityEngine;

public class EndlessReturnToPointVolume : EndlessTriggerVolume
{
	[SerializeField]
	private Transform _returnPoint;
	[SerializeField]
	private Vector3 _localReturnVelocity;
}
