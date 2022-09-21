using UnityEngine;

public class GhostDirector : MonoBehaviour
{
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	protected DreamArrivalPoint _dreamArrivalPoint;
	[SerializeField]
	protected GhostBrain[] _directedGhosts;
	[SerializeField]
	protected bool _startAwake;
	[SerializeField]
	private OWAudioSource _ghostGroupDeathAudioSource;
}
