using UnityEngine;

public class RailFluidVolume : FluidVolume
{
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private float _inwardSpeed;
	[SerializeField]
	private float _inwardFalloffRadius;
	[SerializeField]
	private bool _horizontalInwardVelocityOnly;
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private Transform _railPointsRoot;
	[SerializeField]
	private bool _preventPlayerGrounded;
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private Vector3[] _railPoints;
}
