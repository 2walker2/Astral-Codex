using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float intensity;
			public float radius;
			public AmbientOcclusionModel.SampleCount sampleCount;
			public bool downsampling;
			public bool forceForwardCompatibility;
			public bool ambientOnly;
			public bool highPrecision;
		}

		public enum SampleCount
		{
			Lowest = 3,
			Low = 6,
			Medium = 10,
			High = 16,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
