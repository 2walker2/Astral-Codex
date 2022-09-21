using UnityEngine;

public class AlignWithDirection : MonoBehaviour
{
	private enum InterpolationMode
	{
		None = 0,
		Exponential = 1,
		Linear = 2,
		InverseExponential = 3,
	}

	[SerializeField]
	protected Vector3 _localAlignmentAxis;
	[SerializeField]
	private InterpolationMode _interpolationMode;
	[SerializeField]
	private float _interpolationRate;
	[SerializeField]
	private bool _usePhysicsToRotate;
}
