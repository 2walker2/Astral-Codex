using UnityEngine;

public class NomaiWarpStreaming : SectoredMonoBehaviour
{
	[SerializeField]
	private string _destinationSceneName;
	[SerializeField]
	private NomaiWarpTransmitter _warpTransmitter;
	[SerializeField]
	private float _streamingAngle;
	[SerializeField]
	private NomaiWarpReceiver _warpReceiver;
}
