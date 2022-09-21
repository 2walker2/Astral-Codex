using UnityEngine;

public class ShipDirectionalForceVolume : ForceVolume
{
	[SerializeField]
	private Vector3 _fieldDirection;
	[SerializeField]
	private float _fieldMagnitude;
}
