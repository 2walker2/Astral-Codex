using UnityEngine;

public class RotatingDoor : AbstractDoor
{
	[SerializeField]
	private Transform[] _doorPannelRight;
	[SerializeField]
	private Transform[] _doorPannelLeft;
	[SerializeField]
	private float _openRotation;
	[SerializeField]
	private float _openingSpeed;
	[SerializeField]
	private float _closingSpeed;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private AudioType _openStartClip;
	[SerializeField]
	private AudioType _openStopClip;
	[SerializeField]
	private AudioType _closeStartClip;
	[SerializeField]
	private AudioType _closeStopClip;
	[SerializeField]
	private VolumeOcclusionLight _occlusionLight;
}
