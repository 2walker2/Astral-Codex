using UnityEngine;

public class WhiteHoleVolume : MonoBehaviour
{
	[SerializeField]
	private Sector _whiteHoleSector;
	[SerializeField]
	private NomaiAirlock[] _airlocksToOpen;
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _debrisDistMin;
	[SerializeField]
	private float _debrisDistMax;
}
