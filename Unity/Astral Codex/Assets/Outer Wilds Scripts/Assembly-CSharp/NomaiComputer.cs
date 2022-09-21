using UnityEngine;

public class NomaiComputer : NomaiText
{
	[SerializeField]
	private bool _startActivated;
	[SerializeField]
	private float _dockedHeight;
	[SerializeField]
	private float _minHeight;
	[SerializeField]
	private float _maxHeight;
	[SerializeField]
	private OWAudioSource _ambientAudioSource;
	[SerializeField]
	private OWAudioSource _oneShotAudioSource;
	[SerializeField]
	private float _fadeLength;
}
