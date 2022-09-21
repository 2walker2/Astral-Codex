using UnityEngine;
using System;
using System.Collections.Generic;

public class VolumeOcclusionGroup : MonoBehaviour
{
	[Serializable]
	public struct OcclusionVolumeData
	{
		public OcclusionVolumeData(VolumeOcclusionRenderer vor, float s) : this()
		{
		}

		public VolumeOcclusionRenderer occlusionVolume;
		public float originalStrength;
	}

	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private List<VolumeOcclusionGroup.OcclusionVolumeData> _occlusionVolumes;
	[SerializeField]
	private List<VolumeOcclusionLight> _staticOcclusionLights;
	[SerializeField]
	private List<OWVolumeOcclusionLight> _dynamicOcclusionLights;
}
