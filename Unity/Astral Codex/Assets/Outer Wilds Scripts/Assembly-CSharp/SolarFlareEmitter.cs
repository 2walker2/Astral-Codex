using UnityEngine;

public class SolarFlareEmitter : MonoBehaviour
{
	[SerializeField]
	private GameObject _streamerPrefab;
	[SerializeField]
	private GameObject _loopPrefab;
	[SerializeField]
	private GameObject _domePrefab;
	[SerializeField]
	private float _lifeLength;
	[SerializeField]
	private Color _tint;
	[SerializeField]
	private float _minTimeBetweenFlares;
	[SerializeField]
	private float _maxTimeBetweenFlares;
	[SerializeField]
	private AnimationCurve _flareFrequencyTimeloopScale;
	[SerializeField]
	private int _minStreamersPerFlare;
	[SerializeField]
	private int _maxStreamersPerFlare;
	[SerializeField]
	private float _startScale;
	[SerializeField]
	private float _endScale;
}
