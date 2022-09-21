using UnityEngine;

public class InnerFogWarpVolume : SphericalFogWarpVolume
{
	[SerializeField]
	private OuterFogWarpVolume _containerWarpVolume;
	[SerializeField]
	private OuterFogWarpVolume _linkedOuterWarpVolume;
	[SerializeField]
	private OuterFogWarpVolume.Name _linkedOuterWarpName;
	[SerializeField]
	private OWRenderer _fogSphereRenderer;
	[SerializeField]
	private bool _useFarFogColor;
	[SerializeField]
	private Color _farFogColor;
}
