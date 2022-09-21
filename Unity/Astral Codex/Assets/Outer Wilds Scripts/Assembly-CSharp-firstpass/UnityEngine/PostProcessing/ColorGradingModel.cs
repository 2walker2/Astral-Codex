using System;
using UnityEngine;

namespace UnityEngine.PostProcessing
{
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		[Serializable]
		public struct TonemappingSettings
		{
			public ColorGradingModel.Tonemapper tonemapper;
			public float neutralBlackIn;
			public float neutralWhiteIn;
			public float neutralBlackOut;
			public float neutralWhiteOut;
			public float neutralWhiteLevel;
			public float neutralWhiteClip;
		}

		[Serializable]
		public struct BasicSettings
		{
			public float postExposure;
			public float temperature;
			public float tint;
			public float hueShift;
			public float saturation;
			public float contrast;
		}

		[Serializable]
		public struct ChannelMixerSettings
		{
			public Vector3 red;
			public Vector3 green;
			public Vector3 blue;
			public int currentEditingChannel;
		}

		[Serializable]
		public struct LogWheelsSettings
		{
			public Color slope;
			public Color power;
			public Color offset;
		}

		[Serializable]
		public struct LinearWheelsSettings
		{
			public Color lift;
			public Color gamma;
			public Color gain;
		}

		[Serializable]
		public struct ColorWheelsSettings
		{
			public ColorGradingModel.ColorWheelMode mode;
			public ColorGradingModel.LogWheelsSettings log;
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		[Serializable]
		public struct CurvesSettings
		{
			public ColorGradingCurve master;
			public ColorGradingCurve red;
			public ColorGradingCurve green;
			public ColorGradingCurve blue;
			public ColorGradingCurve hueVShue;
			public ColorGradingCurve hueVSsat;
			public ColorGradingCurve satVSsat;
			public ColorGradingCurve lumVSsat;
			public int e_CurrentEditingCurve;
			public bool e_CurveY;
			public bool e_CurveR;
			public bool e_CurveG;
			public bool e_CurveB;
		}

		[Serializable]
		public struct Settings
		{
			public ColorGradingModel.TonemappingSettings tonemapping;
			public ColorGradingModel.BasicSettings basic;
			public ColorGradingModel.ChannelMixerSettings channelMixer;
			public ColorGradingModel.ColorWheelsSettings colorWheels;
			public ColorGradingModel.CurvesSettings curves;
		}

		public enum Tonemapper
		{
			None = 0,
			ACES = 1,
			Neutral = 2,
		}

		public enum ColorWheelMode
		{
			Linear = 0,
			Log = 1,
		}

		[SerializeField]
		private Settings m_Settings;
	}
}
