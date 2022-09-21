using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		[Serializable]
		public struct DepthSettings
		{
			public float scale;
		}

		[Serializable]
		public struct MotionVectorsSettings
		{
			public float sourceOpacity;
			public float motionImageOpacity;
			public float motionImageAmplitude;
			public float motionVectorsOpacity;
			public int motionVectorsResolution;
			public float motionVectorsAmplitude;
		}

		[Serializable]
		public struct Settings
		{
			public BuiltinDebugViewsModel.Mode mode;
			public BuiltinDebugViewsModel.DepthSettings depth;
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}

		public enum Mode
		{
			None = 0,
			Depth = 1,
			Normals = 2,
			MotionVectors = 3,
			AmbientOcclusion = 4,
			EyeAdaptation = 5,
			FocusPlane = 6,
			PreGradingLog = 7,
			LogLut = 8,
			UserLut = 9,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
