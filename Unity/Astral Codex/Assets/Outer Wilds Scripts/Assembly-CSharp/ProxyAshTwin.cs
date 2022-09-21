using UnityEngine;

public class ProxyAshTwin : ProxyPlanet
{
	[SerializeField]
	private MeshRenderer[] _planetRenderers;
	[SerializeField]
	private TessellatedSphereRenderer _sandRenderer;
	[SerializeField]
	private Transform _sandTransform;
	[SerializeField]
	private Transform _realSandTransform;
	[SerializeField]
	private Transform _sandColumnRoot;
	[SerializeField]
	private Transform _realSandColumnRoot;
	[SerializeField]
	private MeshRenderer _sandColumnRenderer;
	[SerializeField]
	private GameObject _realSandColumnRenderObject;
}
