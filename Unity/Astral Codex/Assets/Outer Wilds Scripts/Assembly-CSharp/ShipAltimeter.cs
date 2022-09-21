using UnityEngine;

public class ShipAltimeter : MonoBehaviour
{
	[SerializeField]
	private Transform _raycastOrigin;
	[SerializeField]
	private float _shipRadius;
	[SerializeField]
	private float _barLength;
	[SerializeField]
	private Transform _shipIcon;
	[SerializeField]
	private Transform _groundBar;
	[SerializeField]
	private DampedSpring _groundBarSpring;
}
