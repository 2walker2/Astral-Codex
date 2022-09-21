using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		[Serializable]
		public struct FxaaSettings
		{
			public AntialiasingModel.FxaaPreset preset;
		}

		[Serializable]
		public struct SmaaSettings
		{
			public AntialiasingModel.SmaaPreset preset;
		}

		[Serializable]
		public struct TaaSettings
		{
			public float jitterSpread;
			public float sharpen;
			public float stationaryBlending;
			public float motionBlending;
		}

		[Serializable]
		public struct Settings
		{
			public AntialiasingModel.Method method;
			public AntialiasingModel.FxaaSettings fxaaSettings;
			public AntialiasingModel.SmaaSettings smaaSettings;
			public AntialiasingModel.TaaSettings taaSettings;
		}

		public enum Method
		{
			Fxaa = 0,
			Smaa = 1,
			Taa = 2,
		}

		public enum FxaaPreset
		{
			ExtremePerformance = 0,
			Performance = 1,
			Default = 2,
			Quality = 3,
			ExtremeQuality = 4,
		}

		public enum SmaaPreset
		{
			LowQuality = 0,
			MediumQuality = 1,
			HighQuality = 2,
			UltraQuality = 3,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
