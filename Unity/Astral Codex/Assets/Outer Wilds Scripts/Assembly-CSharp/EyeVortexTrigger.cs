using UnityEngine;

public class EyeVortexTrigger : MonoBehaviour
{
	[SerializeField]
	private ProbeSafetyVolume _tunnelSafetyVolume;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private GameObject _tunnelObject;
	[SerializeField]
	private OWTriggerVolume _vortexTrigger;
	[SerializeField]
	private OWTriggerVolume _heatLightningTrigger;
	[SerializeField]
	private HeatLightningController _heatLightningController;
	[SerializeField]
	private OWTriggerVolume _entryAudioTrigger;
	[SerializeField]
	private OWTriggerVolume _exitAudioTrigger;
}
