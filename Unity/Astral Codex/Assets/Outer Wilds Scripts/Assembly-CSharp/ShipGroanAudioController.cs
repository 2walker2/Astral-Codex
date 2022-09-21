using UnityEngine;

public class ShipGroanAudioController : MonoBehaviour
{
	[SerializeField]
	private float _jerkMagnitudeGroanThreshold;
	[SerializeField]
	private float _jerkChargeTimeThreshold;
	[SerializeField]
	private float _secondsPreventGroanAfterThrusterFire;
}
