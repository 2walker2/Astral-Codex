using UnityEngine;

public class ShipReactorComponent : ShipComponent
{
	[SerializeField]
	private float _minCountdown;
	[SerializeField]
	private float _maxCountdown;
	[SerializeField]
	private Transform _timerArrow;
	[SerializeField]
	private float _startArrowRotation;
	[SerializeField]
	private float _endArrowRotation;
}
