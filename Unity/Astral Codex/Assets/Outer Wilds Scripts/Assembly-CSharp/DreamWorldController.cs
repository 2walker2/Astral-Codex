using UnityEngine;

public class DreamWorldController : MonoBehaviour
{
	[SerializeField]
	private DreamLanternItem _debugPlayerLantern;
	[SerializeField]
	private Transform _primarySimulationRoot;
	[SerializeField]
	private Transform[] _simulationRoots;
	[SerializeField]
	private SimulationCamera _simulationCamera;
	[SerializeField]
	private OWRenderer _simulationSphere;
	[SerializeField]
	private Sector _dreamWorldSector;
	[SerializeField]
	private OWTriggerVolume _dreamWorldVolume;
	[SerializeField]
	private Color _tempSkyboxColor;
}
