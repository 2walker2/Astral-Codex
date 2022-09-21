using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[SerializeField]
	private SpawnLocation _spawnLocation;
	[SerializeField]
	private bool _isShipSpawn;
	[SerializeField]
	private OWTriggerVolume[] _triggerVolumes;
}
