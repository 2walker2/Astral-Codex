using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public bool colored;
			public float intensity;
			public float size;
			public float luminanceContribution;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
