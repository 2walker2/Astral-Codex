using UnityEngine;

public class DreamElevatorWarpVolume : MonoBehaviour
{
	[SerializeField]
	private Transform _destinationTransform;
	[SerializeField]
	private Sector _destinationSector;
	[SerializeField]
	private CageElevator _trackedElevator;
	[SerializeField]
	private int _ID;
}
