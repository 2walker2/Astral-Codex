using UnityEngine;

public class RandomPointSoundGroup : MonoBehaviour
{
	[SerializeField]
	private AudioType _pointAudioType;
	[SerializeField]
	private Vector2 _delayRange;
	[SerializeField]
	private float _minPlayDistance;
	[SerializeField]
	private AudioVolume _audioVolume;
	[SerializeField]
	private OWAudioSource[] _pointSources;
}
