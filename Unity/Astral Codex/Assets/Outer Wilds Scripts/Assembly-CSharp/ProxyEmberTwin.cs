using UnityEngine;

public class ProxyEmberTwin : ProxyPlanet
{
	[SerializeField]
	private MeshRenderer[] _planetRenderers;
	[SerializeField]
	private TessellatedSphereRenderer _sandRenderer;
	[SerializeField]
	private Transform _sandTransform;
	[SerializeField]
	private Transform _realSandTransform;
}
