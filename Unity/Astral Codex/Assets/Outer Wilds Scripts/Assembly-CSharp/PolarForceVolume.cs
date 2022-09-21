using UnityEngine;

public class PolarForceVolume : ForceVolume
{
	private enum ForceMode
	{
		Polar = 0,
		Tangential = 1,
	}

	[SerializeField]
	private ForceMode _fieldMode;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private Vector3 _localAxis;
}
