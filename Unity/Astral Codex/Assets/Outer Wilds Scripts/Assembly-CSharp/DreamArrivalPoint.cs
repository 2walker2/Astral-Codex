using UnityEngine;

public class DreamArrivalPoint : MonoBehaviour
{
	public enum Location
	{
		Undefined = 0,
		Zone1 = 100,
		Zone2 = 200,
		Zone3 = 300,
		Zone4 = 400,
	}

	[SerializeField]
	private Location _location;
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private Campfire _campfire;
	[SerializeField]
	private DreamExplosionController _explosionController;
	[SerializeField]
	private OWTriggerVolume[] _entrywayVolumes;
	[SerializeField]
	private Transform _raftSpawn;
}
