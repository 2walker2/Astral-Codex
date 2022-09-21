using UnityEngine;

public class RotatingDoubleDoor : AbstractDoor
{
	[SerializeField]
	private float _openDegrees;
	[SerializeField]
	private float _closedDegrees;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private Transform _leftDoor;
	[SerializeField]
	private Transform _rightDoor;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
