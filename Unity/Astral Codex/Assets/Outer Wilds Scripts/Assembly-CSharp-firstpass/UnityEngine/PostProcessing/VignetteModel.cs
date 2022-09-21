using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public VignetteModel.Mode mode;
			public Color color;
			public Vector2 center;
			public float intensity;
			public float smoothness;
			public float roundness;
			public Texture mask;
			public float opacity;
			public bool rounded;
		}

		public enum Mode
		{
			Classic = 0,
			Masked = 1,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
