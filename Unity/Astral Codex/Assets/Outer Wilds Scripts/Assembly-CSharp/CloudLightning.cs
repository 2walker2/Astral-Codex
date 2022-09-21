using UnityEngine;
using System;

public class CloudLightning : MonoBehaviour
{
	[Serializable]
	public class AnimSettings
	{
		public AnimationCurve radiusScale;
		public AnimationCurve intensityScale;
	}

	[SerializeField]
	private float _lightLength;
	[SerializeField]
	private float _lightRadius;
	[SerializeField]
	private float _lightIntensity;
	[SerializeField]
	private AnimSettings _lightAnimSettings;
}
