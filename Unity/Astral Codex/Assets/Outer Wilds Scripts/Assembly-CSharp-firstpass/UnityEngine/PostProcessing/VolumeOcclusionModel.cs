using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class VolumeOcclusionModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public bool downsampling;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
