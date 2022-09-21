using UnityEngine;

public class TractorBeamFluid : FluidVolume
{
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _height;
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private float _reverseSpeed;
	[SerializeField]
	private float _inwardSpeed;
	[SerializeField]
	private float _outwardSpeed;
	[SerializeField]
	private float _exitLength;
	[SerializeField]
	private float _exitOffset;
	[SerializeField]
	private bool _fadeBeamIfPlayerInside;
	[SerializeField]
	private TractorBeamParticleController _ringParticleController;
}
