using UnityEngine;

public class VisorRainEffectVolume : VisorEffectVolume
{
	public enum RainDirection
	{
		Linear = 0,
		Radial = 1,
	}

	[SerializeField]
	private RainDirection _rainDirection;
	[SerializeField]
	private float _dropletRate;
	[SerializeField]
	private AnimationCurve _dropletDirScale;
	[SerializeField]
	private float _streakRate;
	[SerializeField]
	private AnimationCurve _streakDirScale;
}
