using UnityEngine;

public class VideoPlayerController : SectoredMonoBehaviour
{
	[SerializeField]
	private AudioSource _audioSource;
	[SerializeField]
	private string _streamingVideoFileName;
	[SerializeField]
	private AudioType _splitAudioType;
}
