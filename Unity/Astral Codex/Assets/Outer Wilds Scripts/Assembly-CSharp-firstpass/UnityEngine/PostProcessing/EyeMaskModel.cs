using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class EyeMaskModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public Texture2D eyeMask;
			public float openness;
			public float blendWidth;
			public bool edgeColorMode;
			public Color edgeColor;
			public bool linesEnabled;
			public Texture2D linesRamp;
			public Texture2D linesMask;
			public float linesProgress;
			public float linesWidth;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
