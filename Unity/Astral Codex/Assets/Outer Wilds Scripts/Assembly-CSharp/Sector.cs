using UnityEngine;
using System.Collections.Generic;

public class Sector : MonoBehaviour
{
	public enum Name
	{
		Unnamed = 0,
		Sun = 1,
		HourglassTwin_A = 2,
		HourglassTwin_B = 3,
		TimberHearth = 4,
		BrittleHollow = 5,
		GiantsDeep = 6,
		DarkBramble = 7,
		Comet = 8,
		QuantumMoon = 9,
		TimberMoon = 10,
		BrambleDimension = 11,
		VolcanicMoon = 12,
		OrbitalProbeCannon = 13,
		EyeOfTheUniverse = 14,
		Ship = 15,
		SunStation = 16,
		WhiteHole = 17,
		TimeLoopDevice = 18,
		Vessel = 19,
		VesselDimension = 20,
		HourglassTwins = 21,
		InvisiblePlanet = 22,
		DreamWorld = 23,
	}

	[SerializeField]
	private Name _name;
	[SerializeField]
	private GameObject _triggerRoot;
	[SerializeField]
	private List<Sector> _subsectors;
	[SerializeField]
	private string _idString;
}
