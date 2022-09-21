using UnityEngine;

public class GhostData
{
	public enum ThreatAwareness
	{
		EverythingIsNormal = 0,
		SomethingIsAmiss = 10,
		SomeoneIsInHere = 20,
		IntruderConfirmed = 30,
	}

	public ThreatAwareness threatAwareness;
	public GhostAction.Name currentAction;
	public GhostAction.Name previousAction;
	public bool isAlive;
	public bool hasWokenUp;
	public bool isPlayerLocationKnown;
	public bool wasPlayerLocationKnown;
	public bool reduceGuardUtility;
	public bool fastStalkUnlocked;
	public float timeLastSawPlayer;
	public float timeSincePlayerLocationKnown;
	public float playerMinLanternRange;
	public float illuminatedByPlayerMeter;
	public bool hasChokePoint;
	public Vector3 chokePointLocalPosition;
	public Vector3 chokePointLocalFacing;
	public bool reducedFrights_allowChase;
}
