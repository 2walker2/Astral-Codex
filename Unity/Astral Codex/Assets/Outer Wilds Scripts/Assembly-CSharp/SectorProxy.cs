using UnityEngine;
using System;
using System.Collections.Generic;

public class SectorProxy : MonoBehaviour
{
	[Serializable]
	private struct LightData
	{
		public LightData(Light l, float i) : this()
		{
		}

		public Light light;
		public float originalIntensity;
	}

	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private List<Renderer> _renderers;
	[SerializeField]
	private List<SectorProxy.LightData> _lights;
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	private bool _crossfade;
	[SerializeField]
	private float _crossfadeLength;
	[SerializeField]
	protected Sector _exclusiveSector;
}
