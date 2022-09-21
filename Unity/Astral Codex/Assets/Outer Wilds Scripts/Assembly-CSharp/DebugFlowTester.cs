using UnityEngine;

public class DebugFlowTester : MonoBehaviour
{
	[SerializeField]
	private float _riverSpeed;
	[SerializeField]
	private bool _snapToSurface;
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private Transform _flowTestTransform;
	[SerializeField]
	private Vector3 _flowTestPosition;
	[SerializeField]
	private Vector3 _flowTestVelocity;
}
