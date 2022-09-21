using UnityEngine;

public class AnglerfishController : SectoredMonoBehaviour
{
	[SerializeField]
	private Vector3 _mouthOffset;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _investigateSpeed;
	[SerializeField]
	private float _chaseSpeed;
	[SerializeField]
	private float _turnSpeed;
	[SerializeField]
	private float _quickTurnSpeed;
	[SerializeField]
	private float _arrivalDistance;
	[SerializeField]
	private float _pursueDistance;
	[SerializeField]
	private float _escapeDistance;
	[SerializeField]
	private float _consumeShipCrushDelay;
	[SerializeField]
	private float _consumeDeathDelay;
}
