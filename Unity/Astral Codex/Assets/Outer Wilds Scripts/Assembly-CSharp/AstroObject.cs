using UnityEngine;

public class AstroObject : MonoBehaviour
{
	public enum Type
	{
		None = 0,
		Star = 1,
		Planet = 2,
		Moon = 3,
		Comet = 4,
		SpaceStation = 5,
		Satellite = 6,
	}

	public enum Name
	{
		None = 0,
		CustomString = 1,
		Sun = 2,
		CaveTwin = 3,
		TowerTwin = 4,
		TimberHearth = 5,
		BrittleHollow = 6,
		GiantsDeep = 7,
		DarkBramble = 8,
		Comet = 9,
		WhiteHole = 10,
		WhiteHoleTarget = 11,
		QuantumMoon = 12,
		RingWorld = 13,
		ProbeCannon = 14,
		TimberMoon = 15,
		VolcanicMoon = 16,
		Eye = 17,
		HourglassTwins = 18,
		SunStation = 19,
		DreamWorld = 20,
		MapSatellite = 21,
	}

	[SerializeField]
	private Type _type;
	[SerializeField]
	private Name _name;
	[SerializeField]
	private string _customName;
	[SerializeField]
	private AstroObject _primaryBody;
	[SerializeField]
	private AstroObject _moon;
	[SerializeField]
	private AstroObject _satellite;
	[SerializeField]
	private Sector _rootSector;
	[SerializeField]
	private GravityVolume _gravityVolume;
	[SerializeField]
	private SandLevelController _sandLevelController;
}
