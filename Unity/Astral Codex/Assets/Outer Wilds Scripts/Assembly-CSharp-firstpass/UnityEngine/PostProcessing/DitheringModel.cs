using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float strength;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
