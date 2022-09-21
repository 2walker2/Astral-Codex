using UnityEngine;

public class AudioVolumeWithOverlay : AudioVolume
{
	[SerializeField]
	private AudioType _mainTrackAudio;
	[SerializeField]
	private AudioType _overlayTrackAudio;
	[SerializeField]
	private OWAudioSource _overlayAudioSource1;
	[SerializeField]
	private OWAudioSource _overlayAudioSource2;
	[SerializeField]
	private bool _debug;
}
