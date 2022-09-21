using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class CustomGammaModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float gamma;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
