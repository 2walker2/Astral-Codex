using UnityEngine;

public class SignMazeTrigger : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _trigger;
	[SerializeField]
	private GameObject _activateObject;
	[SerializeField]
	private OWTriggerVolume _activateTrigger;
	[SerializeField]
	private AudioSignal _activateSignal;
	[SerializeField]
	private AudioSignal _deactivateSignal;
}
