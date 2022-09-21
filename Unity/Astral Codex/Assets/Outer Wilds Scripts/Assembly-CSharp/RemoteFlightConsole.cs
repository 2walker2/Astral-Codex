using UnityEngine;

public class RemoteFlightConsole : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _modelShipBody;
	[SerializeField]
	private OWRigidbody _suspensionBody;
	[SerializeField]
	private OWCollider _playerProxyCollider;
	[SerializeField]
	private Transform _respawnPoint;
	[SerializeField]
	private float _respawnLength;
	[SerializeField]
	private SingularityWarpEffect _respawnEffect;
	[SerializeField]
	private GameObject _respawnProxyGeometry;
	[SerializeField]
	private OWAudioSource _consoleAudio;
}
