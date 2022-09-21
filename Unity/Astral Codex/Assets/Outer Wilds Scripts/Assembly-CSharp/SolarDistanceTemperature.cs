using UnityEngine;

public class SolarDistanceTemperature : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _distanceCurve;
	[SerializeField]
	private float _maxTempK;
	[SerializeField]
	private float _minTempK;
	[SerializeField]
	private float _maxDistance;
	[SerializeField]
	private float _minDistance;
}
