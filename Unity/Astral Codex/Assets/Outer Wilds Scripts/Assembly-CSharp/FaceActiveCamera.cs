using UnityEngine;

public class FaceActiveCamera : MonoBehaviour
{
	[SerializeField]
	private Vector3 _localFacingVector;
	[SerializeField]
	private Vector3 _localRotationAxis;
	[SerializeField]
	private bool _useLookAt;
}
