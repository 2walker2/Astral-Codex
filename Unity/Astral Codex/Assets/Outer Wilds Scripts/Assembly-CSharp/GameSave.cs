using System;
using System.Collections.Generic;

[Serializable]
public class GameSave
{
	public int loopCount;
	public bool[] knownFrequencies;
	public List<string> newlyRevealedFactIDs;
	public DeathType lastDeathType;
	public int burnedMarshmallowEaten;
	public uint fullTimeloops;
	public uint perfectMarshmallowsEaten;
	public bool warpedToTheEye;
	public float secondsRemainingOnWarp;
	public int loopCountOnParadox;
	public StartupPopups shownPopups;
	public string version;
}
