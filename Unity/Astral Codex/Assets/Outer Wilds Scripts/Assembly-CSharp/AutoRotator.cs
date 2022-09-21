using UnityEngine;

public class AutoRotator : MonoBehaviour
{
	private enum RotationAxis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[SerializeField]
	private RotationAxis _visualRotationAxis;
	[SerializeField]
	private RotationAxis _actualRotationAxis;
	[SerializeField]
	private float _totalRotationTime;
	[SerializeField]
	private float _maxRotationSpeed;
	[SerializeField]
	private DampedSpringRadial _rotationSpringRampUp;
	[SerializeField]
	private DampedSpringRadial _rotationSpringRampDown;
	[SerializeField]
	private bool _startOnLoad;
	[SerializeField]
	private bool _rampUpRotation;
	[SerializeField]
	private bool _rampDownRotation;
}
