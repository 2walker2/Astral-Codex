using UnityEngine;

public class RiverPathAudioSource : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource[] _audioPool;
	[SerializeField]
	private float _muffledVolume;
	[SerializeField]
	private float _crossfadeInDuration;
	[SerializeField]
	private float _crossfadeOutDuration;
	[SerializeField]
	private float _crossfadeThreshold;
	[SerializeField]
	private float _minShoreFollowSpeed;
}
