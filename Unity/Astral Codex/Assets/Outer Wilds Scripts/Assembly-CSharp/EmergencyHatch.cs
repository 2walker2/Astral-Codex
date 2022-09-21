using UnityEngine;

public class EmergencyHatch : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _openHatchSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private float _ejectSpeed;
	[SerializeField]
	private Vector3 _localAngularVelocity;
	[SerializeField]
	private Vector3 _localVelocityOffset;
}
