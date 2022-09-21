using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public bool excludeSkybox;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
