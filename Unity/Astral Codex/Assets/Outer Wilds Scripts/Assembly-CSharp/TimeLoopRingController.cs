using UnityEngine;

public class TimeLoopRingController : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _onSlot;
	[SerializeField]
	private NomaiInterfaceSlot _offSlot;
	[SerializeField]
	private OWRigidbody _ringBody;
	[SerializeField]
	private ForceVolume[] _alignmentVolumes;
	[SerializeField]
	private OWAudioSource _audioSource;
}
