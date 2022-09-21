using System;
using UnityEngine;

[Serializable]
public class TurbulenceAudio
{
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private float _maxDensity;
	[SerializeField]
	private float _lowerSpeedLimit;
	[SerializeField]
	private float _upperSpeedLimit;
	[SerializeField]
	private float _easeRate;
}
