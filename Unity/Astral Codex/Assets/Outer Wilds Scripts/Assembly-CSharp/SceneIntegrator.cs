using UnityEngine;

public class SceneIntegrator : MonoBehaviour
{
	[SerializeField]
	private bool _enableCenterOfTheUniverse;
	[SerializeField]
	private Vector3 _startPosition;
	[SerializeField]
	private Vector3 _startRotation;
	[SerializeField]
	private AstroObject _primaryAstroObject;
	[SerializeField]
	private InitialMotion _rootInitialMotion;
	[SerializeField]
	private ConstantForceDetector _rootForceDetector;
	[SerializeField]
	private bool _spawnPlayer;
	[SerializeField]
	private bool _spawnShip;
	[SerializeField]
	private bool _useDebugLoopCount;
	[SerializeField]
	private int _debugLoopCount;
	[SerializeField]
	private int _debugStartAtMinute;
	[SerializeField]
	private bool _spawnDLCPhotographer;
	[SerializeField]
	private SpawnPoint _defaultPlayerSpawnPoint;
	[SerializeField]
	private SpawnPoint _defaultShipSpawnPoint;
}
