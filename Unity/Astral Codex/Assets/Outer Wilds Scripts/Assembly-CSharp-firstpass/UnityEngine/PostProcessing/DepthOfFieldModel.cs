using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float focusDistance;
			public float aperture;
			public float focalLength;
			public bool useCameraFov;
			public DepthOfFieldModel.KernelSize kernelSize;
		}

		public enum KernelSize
		{
			Small = 0,
			Medium = 1,
			Large = 2,
			VeryLarge = 3,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
