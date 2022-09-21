using UnityEngine;

public class JetpackThrusterModel : ThrusterModel
{
	[SerializeField]
	private float _boostGroundVelocity;
	[SerializeField]
	private float _boostThrust;
	[SerializeField]
	private float _boostSeconds;
	[SerializeField]
	private float _chargeSecondsGround;
	[SerializeField]
	private float _chargeSecondsAir;
}
