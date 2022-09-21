using UnityEngine;

public class ProxyOrbiter : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer[] _renderers;
	[SerializeField]
	private Transform _originalBody;
	[SerializeField]
	private Transform _originalPlanetBody;
	[SerializeField]
	private ProxyBody _proxyPlanetBody;
}
