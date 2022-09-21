using UnityEngine;

public class IllusoryWall : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private float _fadeOutDuration;
	[SerializeField]
	private float _fadeInDuration;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private bool _toggleShadowCasting;
}
