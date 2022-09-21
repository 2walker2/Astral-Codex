using UnityEngine;

public class GhostPartyDirector : GhostDirector
{
	[SerializeField]
	private OWTriggerVolume _doorGhostTrigger;
	[SerializeField]
	private OWTriggerVolume _doorTrapTrigger;
	[SerializeField]
	private AbstractDoor _entryDoor;
	[SerializeField]
	private OWTriggerVolume _ambushTrigger;
	[SerializeField]
	private float _initialAmbushDelay;
	[SerializeField]
	private float _secondaryAmbushDelay;
	[SerializeField]
	private GhostBrain _fireplaceGhost;
	[SerializeField]
	private GhostBrain[] _ambushGhosts;
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private PartyMusicController _partyMusicController;
	[SerializeField]
	private GameObject _shipLogFactObject;
}
