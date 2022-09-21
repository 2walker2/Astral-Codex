using UnityEngine;

public class SphereOceanFluidVolume : RadialFluidVolume
{
	[SerializeField]
	private float _surfaceCurrentSpeed;
	[SerializeField]
	private float _equatorRepelAngle;
	[SerializeField]
	private float _equatorRepelSpeed;
	[SerializeField]
	private float _barrierUpperRadius;
	[SerializeField]
	private float _barrierLowerRadius;
	[SerializeField]
	private float _barrierRepelSpeed;
}
