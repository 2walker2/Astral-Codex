using UnityEngine;

public class OWRigidbody : MonoBehaviour
{
	[SerializeField]
	private bool _kinematicSimulation;
	[SerializeField]
	private bool _autoGenerateCenterOfMass;
	[SerializeField]
	private Vector3 _centerOfMass;
	[SerializeField]
	private bool _isTargetable;
	[SerializeField]
	private bool _maintainOriginalCenterOfMass;
	[SerializeField]
	private Sector _simulateInSector;
}
