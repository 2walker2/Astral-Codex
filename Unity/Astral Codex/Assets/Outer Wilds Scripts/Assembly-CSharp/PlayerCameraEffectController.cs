using UnityEngine;

public class PlayerCameraEffectController : MonoBehaviour
{
	[SerializeField]
	private float _winceFadeLength;
	[SerializeField]
	private AnimationCurve _winceEffectCurve;
	[SerializeField]
	private AnimationCurve _winceExposure;
	[SerializeField]
	private AnimationCurve _winceSaturation;
	[SerializeField]
	private AnimationCurve _winceContrast;
	[SerializeField]
	private float _phospheneFadeLength;
	[SerializeField]
	private AnimationCurve _phospheneBrightness;
	[SerializeField]
	private float _wakeLength;
	[SerializeField]
	private AnimationCurve _fastWakeCurve;
	[SerializeField]
	private AnimationCurve _calmWakeCurve;
	[SerializeField]
	private float _defaultDeathFadeLength;
	[SerializeField]
	private float _impactSlowFadeLength;
	[SerializeField]
	private float _suicideSlowFadeLength;
	[SerializeField]
	private AnimationCurve _impactSlowCurve;
	[SerializeField]
	private float _impactQuickFadeLength;
	[SerializeField]
	private float _impactQuickDeathSpeed;
	[SerializeField]
	private float _asphyxiationFadeLength;
	[SerializeField]
	private float _energyFadeLength;
	[SerializeField]
	private float _bigBangFadeLength;
	[SerializeField]
	private float _digestionFadeLength;
	[SerializeField]
	private float _timeLoopFadeLength;
	[SerializeField]
	private Texture2D _timeLoopEyeMask;
	[SerializeField]
	private float _timeLoopBlendWidth;
	[SerializeField]
	private AnimationCurve _timeLoopEyeMaskCurve;
	[SerializeField]
	private AnimationCurve _timeLoopLinesProgressionCurve;
	[SerializeField]
	private float _escapeTimeLoopFadeLength;
	[SerializeField]
	private float _blackHoleFadeLength;
	[SerializeField]
	private float _realityShatterLength;
	[SerializeField]
	private float _dreamFadeLength;
	[SerializeField]
	private AnimationCurve _realityShardShatterCurve;
	[SerializeField]
	private AnimationCurve _realityShardOffsetCurve;
	[SerializeField]
	private AnimationCurve _realityShardDissolveWidthCurve;
	[SerializeField]
	private AnimationCurve _realityShardDissolveProgressCurve;
}
