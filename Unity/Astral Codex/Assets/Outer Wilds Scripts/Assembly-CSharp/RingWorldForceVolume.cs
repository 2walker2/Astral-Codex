using UnityEngine;

public class RingWorldForceVolume : ForceVolume
{
	[SerializeField]
	private AnimationCurve _radiusToAcceleration;
	[SerializeField]
	private RingWorldController _ringWorldController;
}
