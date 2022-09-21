using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		[Serializable]
		public struct ReflectionSettings
		{
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;
			public float maxDistance;
			public float smoothnessCutoff;
			public int iterationCount;
			public int stepSize;
			public float widthModifier;
			public float reflectionBlur;
			public bool reflectBackfaces;
		}

		[Serializable]
		public struct IntensitySettings
		{
			public float reflectionMultiplier;
			public float fadeDistance;
			public float fresnelFade;
			public float fresnelFadePower;
		}

		[Serializable]
		public struct ScreenEdgeMask
		{
			public float intensity;
		}

		[Serializable]
		public struct Settings
		{
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;
			public ScreenSpaceReflectionModel.IntensitySettings intensity;
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}

		public enum SSRReflectionBlendType
		{
			PhysicallyBased = 0,
			Additive = 1,
		}

		public enum SSRResolution
		{
			High = 0,
			Low = 2,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
