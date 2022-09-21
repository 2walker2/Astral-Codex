using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float shutterAngle;
			public int sampleCount;
			public float frameBlending;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
