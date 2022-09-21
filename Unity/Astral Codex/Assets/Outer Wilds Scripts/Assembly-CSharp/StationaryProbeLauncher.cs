using UnityEngine;

public class StationaryProbeLauncher : ProbeLauncher
{
	[SerializeField]
	private Transform _verticalPivot;
	[SerializeField]
	private VisibilityTracker _targetVisibilityTracker;
	[SerializeField]
	private bool _photosOnly;
	[SerializeField]
	private bool _lockInputY;
	[SerializeField]
	private bool _returnToStartPos;
	[SerializeField]
	private float _initialDegreesY;
	[SerializeField]
	private OWAudioSource _audioSource;
}
