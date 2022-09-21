using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public Texture2D lut;
			public float contribution;
			public bool excludeAlpha;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
