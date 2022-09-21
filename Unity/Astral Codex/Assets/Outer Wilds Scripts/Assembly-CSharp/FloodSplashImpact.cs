using UnityEngine;

public class FloodSplashImpact : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private OWRenderer _renderer;
	[SerializeField]
	private float _lifetime;
	[SerializeField]
	private float _delay;
	[SerializeField]
	private AnimationCurve _yOffsetOverLife;
	[SerializeField]
	private AnimationCurve _cutoffOverLife;
}
