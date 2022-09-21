using UnityEngine;

public class WhiteHoleStationRotation : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _slotClockwise;
	[SerializeField]
	private NomaiInterfaceSlot _slotCounterClockwise;
	[SerializeField]
	private OWRigidbody _stationBody;
	[SerializeField]
	private float _stationSlowdownFriction;
	[SerializeField]
	private float _stationAngularAcceleration;
	[SerializeField]
	private float _maxAngularVelocity;
	[SerializeField]
	private float _alignmentAngularVelThreshold;
	[SerializeField]
	private OWLightController _onLights;
	[SerializeField]
	private OWLightController _offLights;
	[SerializeField]
	private OWAudioSource _audioSource;
}
