using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public Texture2D spectralTexture;
			public float intensity;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
