using UnityEngine;

public class MapSatelliteOrbitLine : OrbitLine
{
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[SerializeField]
	private float _lockOnFadeLength;
	[SerializeField]
	private float _minAlpha;
}
