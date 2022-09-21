using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class EyeAdaptationModel : PostProcessingModel
	{
		[Serializable]
		public struct Settings
		{
			public float lowPercent;
			public float highPercent;
			public float minLuminance;
			public float maxLuminance;
			public float keyValue;
			public bool dynamicKeyValue;
			public EyeAdaptationModel.EyeAdaptationType adaptationType;
			public float speedUp;
			public float speedDown;
			public int logMin;
			public int logMax;
		}

		public enum EyeAdaptationType
		{
			Progressive = 0,
			Fixed = 1,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
