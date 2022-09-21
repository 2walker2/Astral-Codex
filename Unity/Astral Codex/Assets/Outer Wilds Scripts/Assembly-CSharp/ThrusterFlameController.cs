using UnityEngine;

public class ThrusterFlameController : MonoBehaviour
{
	[SerializeField]
	private Thruster _thruster;
	[SerializeField]
	private Light _light;
	[SerializeField]
	private AnimationCurve _scaleByThrust;
	[SerializeField]
	private DampedSpring _scaleSpring;
	[SerializeField]
	private float _belowMaxThrustScalar;
}
