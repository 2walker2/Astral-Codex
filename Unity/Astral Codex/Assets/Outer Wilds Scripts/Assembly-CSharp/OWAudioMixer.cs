using UnityEngine;
using UnityEngine.Audio;

public class OWAudioMixer : MonoBehaviour
{
	public enum TrackName
	{
		Undefined = 0,
		Menu = 1,
		Music = 2,
		Environment = 4,
		Environment_Unfiltered = 5,
		EndTimes_SFX = 8,
		Signal = 16,
		Death = 32,
		Player = 64,
		Player_External = 65,
		Ship = 128,
		Map = 256,
		EndTimes_Music = 512,
		MuffleWhileRafting = 1024,
		MuffleIndoors = 2048,
		SlideReelMusic = 4096,
	}

	[SerializeField]
	private AudioMixer _unityMixer;
	[SerializeField]
	private TrackName _trackToFind;
}
