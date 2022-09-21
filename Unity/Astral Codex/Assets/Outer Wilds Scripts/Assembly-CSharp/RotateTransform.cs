using UnityEngine;

public class RotateTransform : MonoBehaviour
{
	[SerializeField]
	private Vector3 _localAxis;
	[SerializeField]
	private float _degreesPerSecond;
	[SerializeField]
	private bool _randomizeRotationRate;
	[SerializeField]
	private float _minRandomRate;
	[SerializeField]
	private float _maxRandomRate;
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private DynamicOccupantMask _sectorOccupantMask;
}
