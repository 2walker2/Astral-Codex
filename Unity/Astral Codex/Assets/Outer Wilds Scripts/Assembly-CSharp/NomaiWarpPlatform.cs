using UnityEngine;

public class NomaiWarpPlatform : MonoBehaviour
{
	public enum Frequency
	{
		None = 0,
		SunStation = 1,
		TimeLoop = 2,
		HourglassTwin = 3,
		TimberHearth = 4,
		BrittleHollowPolar = 5,
		BrittleHollowForge = 6,
		GiantsDeep = 7,
		Vessel = 8,
	}

	[SerializeField]
	private Frequency _frequency;
	[SerializeField]
	private Transform _platformCenter;
	[SerializeField]
	private Vector3 _localWarpPosition;
	[SerializeField]
	private float _warpRadius;
	[SerializeField]
	private bool _ignoreRelativeRotation;
	[SerializeField]
	private SingularityController _blackHole;
	[SerializeField]
	private SingularityController _whiteHole;
}
