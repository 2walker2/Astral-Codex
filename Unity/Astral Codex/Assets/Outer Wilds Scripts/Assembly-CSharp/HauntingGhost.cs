using UnityEngine;

public class HauntingGhost : MonoBehaviour
{
	[SerializeField]
	private HauntedRoom _startingLocation;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private LightCodeReader _lightCodeOpener;
	[SerializeField]
	private bool _seeInAdjacentRooms;
	[SerializeField]
	private HauntedCandle _candle;
}
