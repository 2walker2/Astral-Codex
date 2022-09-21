using UnityEngine;

public class SolarFlareController : MonoBehaviour
{
	[SerializeField]
	private float _lifetimeScale;
	[SerializeField]
	private Vector3 _scaleFactor;
	[SerializeField]
	private Vector2 _uvScrollSpeed;
	[SerializeField]
	private AnimationCurve _alphaOverLifetime;
	[SerializeField]
	private AnimationCurve _maskCutoffOverLifetime;
}
