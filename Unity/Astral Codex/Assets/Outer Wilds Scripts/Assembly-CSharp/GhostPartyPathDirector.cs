using System;
using UnityEngine;

public class GhostPartyPathDirector : GhostDirector
{
	[Serializable]
	private struct GhostSpawnLocation
	{
		public Transform spawnTransform;
		public AbstractDoor spawnDoor;
	}

	[Serializable]
	private struct GhostFinalDestination
	{
		public Transform destinationTransform;
		public ProxyGhostController proxyGhost;
	}

	[SerializeField]
	private GhostSpawnLocation[] _ghostSpawns;
	[SerializeField]
	private float _minGhostDispatchDelay;
	[SerializeField]
	private float _maxGhostDispatchDelay;
	[SerializeField]
	private GhostFinalDestination[] _ghostFinalDestinations;
	[SerializeField]
	private Transform[] _ghostOverflowFinalDestinations;
	[SerializeField]
	private OWTriggerVolume _respawnBlockTrigger;
}
