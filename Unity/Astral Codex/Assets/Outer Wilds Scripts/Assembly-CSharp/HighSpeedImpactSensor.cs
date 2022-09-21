using UnityEngine;

public class HighSpeedImpactSensor : MonoBehaviour
{
	[SerializeField]
	private SectorDetector _sectorDetector;
	[SerializeField]
	private float _checkSpeedThreshold;
	[SerializeField]
	private Vector3 _localOffset;
	[SerializeField]
	private float _radius;
	[SerializeField]
	private bool _verbose;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private Collider _collider;
}
