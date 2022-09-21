using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		[Serializable]
		public struct BloomSettings
		{
			public float intensity;
			public float threshold;
			public float softKnee;
			public float radius;
			public bool antiFlicker;
		}

		[Serializable]
		public struct LensDirtSettings
		{
			public Texture uvTexture;
			public Texture texture;
			public float intensity;
		}

		[Serializable]
		public struct FrostSettings
		{
			public Texture frostTexture;
			public float frostIntensity;
			public float frostRamp;
			public float frostRampWidth;
		}

		[Serializable]
		public struct BreathFogSettings
		{
			public Texture breathFogTexture;
			public Vector4 breathFogTexture_ScaleOffset;
			public float breathFogIntensity;
			public float breathFogRamp;
			public float breathFogFade;
		}

		[Serializable]
		public struct Settings
		{
			public BloomModel.BloomSettings bloom;
			public BloomModel.LensDirtSettings lensDirt;
			public BloomModel.FrostSettings frost;
			public BloomModel.BreathFogSettings breathFog;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
