using UnityEngine;

public class GlitchedCodeDoorInterface : PictureFrameDoorInterface
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private Transform[] _simulationTransforms;
}
