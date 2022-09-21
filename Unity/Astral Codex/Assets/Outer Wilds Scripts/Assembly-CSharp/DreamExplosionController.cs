using UnityEngine;

public class DreamExplosionController : MonoBehaviour
{
	[SerializeField]
	private Transform _scaleRoot;
	[SerializeField]
	private OWRenderer _flameRenderer;
	[SerializeField]
	private OWLight2 _flameLight;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private OWTriggerVolume _deathTrigger;
}
