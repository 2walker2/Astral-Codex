using UnityEngine;

public class DreamSpawnPoint : SpawnPoint
{
	[SerializeField]
	private DreamArrivalPoint.Location _ringWorldSleepLocation;
	[SerializeField]
	private DreamWorldController _dreamController;
	[SerializeField]
	private DreamArrivalPoint _zoneArrivalPoint;
}
