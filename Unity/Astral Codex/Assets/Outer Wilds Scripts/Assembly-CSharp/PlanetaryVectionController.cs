using UnityEngine;

public class PlanetaryVectionController : MonoBehaviour
{
	private enum FollowTarget
	{
		Player = 0,
		Probe = 1,
	}

	[SerializeField]
	private FollowTarget _followTarget;
	[SerializeField]
	private AnimationCurve _densityByHeight;
	[SerializeField]
	private Sector _activeInSector;
	[SerializeField]
	private Sector[] _exclusionSectors;
}
