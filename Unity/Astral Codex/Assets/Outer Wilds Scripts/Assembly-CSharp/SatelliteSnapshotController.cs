using UnityEngine;

public class SatelliteSnapshotController : MonoBehaviour
{
	[SerializeField]
	private bool _allowRearview;
	[SerializeField]
	private bool _showSplashTexture;
	[SerializeField]
	private GameObject _splashObject;
	[SerializeField]
	private GameObject _diagramObject;
	[SerializeField]
	private OWCamera _satelliteCamera;
	[SerializeField]
	private Renderer _projectionScreen;
	[SerializeField]
	private FadeLight _fadeLight;
	[SerializeField]
	private MeshRenderer _probeMesh;
	[SerializeField]
	private OWAudioSource _loopingSource;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
