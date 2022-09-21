using UnityEngine;

public class NomaiRotator : MonoBehaviour
{
	[SerializeField]
	protected float _cycleLength;
	[SerializeField]
	protected NomaiInterfaceSlot[] _openSwitches;
	[SerializeField]
	protected NomaiInterfaceSlot[] _closeSwitches;
	[SerializeField]
	protected NomaiInterfaceSlot[] _cycleSwitches;
	[SerializeField]
	protected OWAudioSource _audioSource;
}
