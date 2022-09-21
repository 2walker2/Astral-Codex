using UnityEngine;

public class SlidingDoor : AbstractDoor
{
	[SerializeField]
	private Transform _doorTransform;
	[SerializeField]
	private Transform _closedSocket;
	[SerializeField]
	private Transform _openSocket;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
