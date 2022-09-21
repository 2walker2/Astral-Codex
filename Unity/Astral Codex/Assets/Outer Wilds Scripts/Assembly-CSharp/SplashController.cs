using UnityEngine;

public class SplashController : MonoBehaviour
{
	[SerializeField]
	private float _lifetime;
	[SerializeField]
	private float _delay;
	[SerializeField]
	private AnimationCurve _yOffsetOverLife;
	[SerializeField]
	private AnimationCurve _cutoffOverLife;
}
