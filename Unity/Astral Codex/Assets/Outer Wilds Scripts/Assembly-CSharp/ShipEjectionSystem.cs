using UnityEngine;

public class ShipEjectionSystem : MonoBehaviour
{
	[SerializeField]
	private ShipDetachableModule _cockpitModule;
	[SerializeField]
	private float _ejectImpulse;
	[SerializeField]
	private Transform _cover;
	[SerializeField]
	private float _coverMoveTime;
	[SerializeField]
	private float _secondPressDelay;
}
