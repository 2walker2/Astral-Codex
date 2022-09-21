using UnityEngine;

public class Minimap : MonoBehaviour
{
	private enum MinimapMode
	{
		Player = 0,
		Ship = 1,
	}

	[SerializeField]
	private MinimapMode _minimapMode;
	[SerializeField]
	private Transform _playerMarkerTransform;
	[SerializeField]
	private Transform _shipMarkerTransform;
	[SerializeField]
	private Transform _probeMarkerTransform;
	[SerializeField]
	private ParticleSystem _playerTrailEmitter;
	[SerializeField]
	private ParticleSystem _probeTrailEmitter;
	[SerializeField]
	private Transform _globeMeshTransform;
	[SerializeField]
	private ProbeLauncher _attachedProbeLauncher;
	[SerializeField]
	private Renderer[] _minimapRenderersToSwitchOnOff;
	[SerializeField]
	private ElectricalComponent[] _electricalComponentsToSwitchOnOff;
}
