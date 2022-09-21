using UnityEngine;

public class PulsingLight : SectoredMonoBehaviour
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[SerializeField]
	private float _pulseRate;
	[SerializeField]
	private float _intensityFluctuation;
	[SerializeField]
	private float _rangeFluctuation;
	[SerializeField]
	private float _timeOffset;
}
