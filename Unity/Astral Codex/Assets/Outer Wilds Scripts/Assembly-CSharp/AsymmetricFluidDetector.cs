using UnityEngine;

public class AsymmetricFluidDetector : FluidDetector
{
	[SerializeField]
	protected Vector3 _dragFactor;
	[SerializeField]
	private Vector3 _angularDragVector;
	[SerializeField]
	private float _angularDragFactor;
}
