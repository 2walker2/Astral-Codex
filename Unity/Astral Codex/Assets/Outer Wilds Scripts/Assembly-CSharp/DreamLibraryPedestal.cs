using UnityEngine;

public class DreamLibraryPedestal : MonoBehaviour
{
	[SerializeField]
	private float _simulationRadiusBuffer;
	[SerializeField]
	private bool _debugDrawFilledSphere;
	[SerializeField]
	private DreamLanternSocket _socket;
	[SerializeField]
	private OWRendererFadeController _lightBeamController;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private Transform _pedestal;
	[SerializeField]
	private Transform[] _flaps;
	[SerializeField]
	private float _maxFlapDegrees;
	[SerializeField]
	private DreamSlideProjector _projector;
	[SerializeField]
	private DreamObjectProjection[] _projections;
	[SerializeField]
	private OWAudioSource _projectionAudio;
	[SerializeField]
	private AbstractDoor[] _doorsToOpen;
	[SerializeField]
	private DreamLibraryFlame[] _flames;
}
