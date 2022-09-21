using UnityEngine;

public class SectorCollisionGroup : CollisionGroup
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private bool _colliderTimeSlicing;
}
