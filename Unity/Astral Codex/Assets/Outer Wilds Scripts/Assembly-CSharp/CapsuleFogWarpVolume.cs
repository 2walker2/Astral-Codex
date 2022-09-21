using UnityEngine;

public class CapsuleFogWarpVolume : FogWarpVolume
{
	[SerializeField]
	protected CapsuleFogWarpVolume _linkedCapsuleWarpVolume;
	[SerializeField]
	protected Vector3 _localExitDirection;
	[SerializeField]
	protected float _radius;
	[SerializeField]
	protected float _height;
	[SerializeField]
	protected float _minExitSpeed;
}
