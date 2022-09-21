using UnityEngine;

public class ShipDamageController : MonoBehaviour
{
	[SerializeField]
	private ExplosionController _explosion;
	[SerializeField]
	private OWTriggerVolume[] _shipTriggerVolumes;
	[SerializeField]
	private GameObject[] _stencils;
}
