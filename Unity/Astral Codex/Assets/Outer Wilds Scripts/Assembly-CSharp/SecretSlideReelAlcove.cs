using UnityEngine;

public class SecretSlideReelAlcove : MonoBehaviour
{
	[SerializeField]
	private bool _closeDoorImmediately;
	[SerializeField]
	private AbstractDoor _door;
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private OWItemSocket _itemSocket;
	[SerializeField]
	private Transform _rotationPivot;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
