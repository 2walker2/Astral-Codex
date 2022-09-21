using UnityEngine;

public class SignalDishController : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot[] _slots;
	[SerializeField]
	private AstroObject.Name[] _astroObjectTargets;
	[SerializeField]
	private SignalDishRingController[] _rings;
	[SerializeField]
	private OWTriggerVolume _signalAudioTrigger;
	[SerializeField]
	private OWAudioSource _signalAudioSource;
}
