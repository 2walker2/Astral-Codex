using UnityEngine;
using System;
using System.Collections.Generic;

public class LightsCullGroup : MonoBehaviour
{
	[Serializable]
	public struct LightData
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
	private List<LightsCullGroup.LightData> _staticLights;
	[SerializeField]
	private List<OWLight2> _dynamicLights;
	[SerializeField]
	private List<LightLOD> _lightLODs;
}
