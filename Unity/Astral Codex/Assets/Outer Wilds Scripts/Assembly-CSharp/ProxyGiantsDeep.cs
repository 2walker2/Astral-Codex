using UnityEngine;

public class ProxyGiantsDeep : ProxyPlanet
{
	[SerializeField]
	private MeshRenderer _mainBody;
	[SerializeField]
	private CloudLightningGenerator _lightningGenerator;
	[SerializeField]
	private ProxyOrbiter[] _cannonChunks;
}
