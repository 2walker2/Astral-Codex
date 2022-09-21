using UnityEngine;

public class ShipGauge : MonoBehaviour
{
	[SerializeField]
	protected ShipLODTrigger _lodTrigger;
	[SerializeField]
	protected Transform _needleTransform;
	[SerializeField]
	protected float _needleAngleMin;
	[SerializeField]
	protected float _needleAngleMax;
	[SerializeField]
	protected OWRenderer _indicatorLight;
	[SerializeField]
	protected float _indicatorWarningThreshold;
	[SerializeField]
	protected Color _indicatorWarningColor;
	[SerializeField]
	protected Color _indicatorCriticalColor;
}
