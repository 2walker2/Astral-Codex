using System;
using UnityEngine;

public class GhostZone2Director : GhostDirector
{
	[Serializable]
	public struct ElevatorPair
	{
		public CageElevator elevator;
		public GhostNodeMap nodeMap;
		public GhostBrain ghost;
		public bool cityDestination;
	}

	[SerializeField]
	private DreamObjectProjector _lightsProjector;
	[SerializeField]
	private OWAudioSource _ghostHowlAudioSource;
	[SerializeField]
	private OWTriggerVolume _undergroundVolume;
	[SerializeField]
	private GhostBrain[] _cityGhosts;
	[SerializeField]
	private GhostBrain[] _undergroundGhosts;
	[SerializeField]
	private ElevatorPair[] _elevators;
	[SerializeField]
	private GhostNodeMap _cityNodeMap;
	[SerializeField]
	private GhostNodeMap _undercityNodeMap;
	[SerializeField]
	private CageElevator _ghostTutorialElevator;
	[SerializeField]
	private OWTriggerVolume _ghostTutorialArrival;
	[SerializeField]
	private AlarmTotem _finalTotem;
	[SerializeField]
	private Transform _teleportNode;
}
