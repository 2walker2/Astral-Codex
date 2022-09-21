using UnityEngine;

public class DayNightAudioVolume : AudioVolume
{
	[SerializeField]
	private AudioType _dayLibraryClip;
	[SerializeField]
	private AudioType _nightLibraryClip;
	[SerializeField]
	private float _dayWindow;
	[SerializeField]
	private OWAudioSource _daySource;
	[SerializeField]
	private OWAudioSource _nightSource;
	[SerializeField]
	private bool _usePlayerPosition;
	[SerializeField]
	private Transform _dayPointTransform;
}
