using UnityEngine;

public class AlignToSurfaceFluidDetector : AsymmetricFluidDetector
{
	[SerializeField]
	private Vector3[] _localAlignmentCheckPoints;
	[SerializeField]
	private FluidVolume _alignmentFluid;
}
