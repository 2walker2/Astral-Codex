using UnityEngine;

public class ShipDamageDisplay : MonoBehaviour
{
	[SerializeField]
	private ShipHull _shipHull;
	[SerializeField]
	private ShipComponent _shipComponent;
	[SerializeField]
	private Material _repairedMaterial;
	[SerializeField]
	private Material _damagedMaterial;
}
