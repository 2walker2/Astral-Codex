using UnityEngine;

public class AlarmBell : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Animation _animation;
	[SerializeField]
	private OWTriggerVolume _bellTrigger;
	[SerializeField]
	private OWLightController _lightController;
}
