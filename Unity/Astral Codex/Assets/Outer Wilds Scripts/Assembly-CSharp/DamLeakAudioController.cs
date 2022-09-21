using UnityEngine;
using System;

public class DamLeakAudioController : MonoBehaviour
{
	[Serializable]
	public struct DamLeakAudio
	{
		[SerializeField]
		private float _startLeakProgression;
		[SerializeField]
		private OWAudioSource _audioSource;
	}

	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private DamDestructionController _damDestructionController;
	[SerializeField]
	private DamLeakAudio[] _leakAudio;
}
