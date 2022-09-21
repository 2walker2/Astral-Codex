using UnityEngine;

public class TornadoFluidVolume : FluidVolume
{
	[SerializeField]
	private Transform _tornadoPivot;
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private float _angularSpeed;
	[SerializeField]
	private float _inwardSpeed;
}
