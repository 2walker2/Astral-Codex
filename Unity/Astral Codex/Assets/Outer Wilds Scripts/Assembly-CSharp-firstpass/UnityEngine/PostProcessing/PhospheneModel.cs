using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class PhospheneModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public Texture2D phospheneTex;
			public Vector4 phospheneTex_ScaleOffset;
			public float visibility;
			public float brightness;
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
