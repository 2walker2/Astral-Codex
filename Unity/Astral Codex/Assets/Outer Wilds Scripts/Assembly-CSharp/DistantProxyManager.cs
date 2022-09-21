using UnityEngine;
using System;

public class DistantProxyManager : MonoBehaviour
{
	[Serializable]
	public struct AstroProxyTuple
	{
		public AstroObject.Name astroName;
		public GameObject proxyPrefab;
	}

	[SerializeField]
	private GameObject _sunProxyPrefab;
	[SerializeField]
	private AstroProxyTuple[] _proxies;
}
