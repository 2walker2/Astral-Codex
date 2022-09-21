using UnityEngine;

public class FicticiousForceDetector : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _nonInertialFrame;
	[SerializeField]
	private Vector3 _angularFrameVelocity;
}
