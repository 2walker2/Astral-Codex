using UnityEngine;

public class NomaiElevator : MonoBehaviour
{
	[SerializeField]
	protected NomaiInterfaceSlot[] _upSwitches;
	[SerializeField]
	protected NomaiInterfaceSlot[] _downSwitches;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _elevationGain;
	[SerializeField]
	private Transform _elevatorRoot;
	[SerializeField]
	private OWAudioSource _audioSource;
}
