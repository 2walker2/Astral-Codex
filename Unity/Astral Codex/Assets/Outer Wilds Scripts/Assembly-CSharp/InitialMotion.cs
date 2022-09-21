using UnityEngine;

public class InitialMotion : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _primaryBody;
	[SerializeField]
	private float _orbitAngle;
	[SerializeField]
	private float _orbitImpulseScalar;
	[SerializeField]
	private Vector3 _rotationAxis;
	[SerializeField]
	private bool _isGlobalAxis;
	[SerializeField]
	private float _initAngularSpeed;
	[SerializeField]
	private Vector3 _initLinearDirection;
	[SerializeField]
	private float _initLinearSpeed;
	[SerializeField]
	private bool _printAxes;
	[SerializeField]
	private bool _printVelocity;
}
