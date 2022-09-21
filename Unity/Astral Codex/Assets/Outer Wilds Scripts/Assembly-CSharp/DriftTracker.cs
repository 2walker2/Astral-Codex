using UnityEngine;

public class DriftTracker : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _body1;
	[SerializeField]
	private OWRigidbody _body2;
	[SerializeField]
	private bool _printSpeed;
	[SerializeField]
	private bool _printDistance;
	[SerializeField]
	private bool _printMassData;
	[SerializeField]
	private bool _printInertiaTensor;
}
