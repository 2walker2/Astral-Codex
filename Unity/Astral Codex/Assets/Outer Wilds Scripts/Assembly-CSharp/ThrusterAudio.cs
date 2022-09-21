using UnityEngine;

public class ThrusterAudio : MonoBehaviour
{
	[SerializeField]
	protected OWAudioSource _translationalSource;
	[SerializeField]
	private OWAudioSource _rotationalSource;
	[SerializeField]
	protected AudioType _rotationClip;
	[SerializeField]
	protected AudioType _underwaterRotationClip;
}
