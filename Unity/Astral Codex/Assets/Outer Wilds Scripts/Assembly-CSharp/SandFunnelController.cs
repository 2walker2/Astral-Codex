using UnityEngine;

public class SandFunnelController : MonoBehaviour
{
	[SerializeField]
	private float _growAfterMinutes;
	[SerializeField]
	private float _shrinkAfterMinutes;
	[SerializeField]
	private Transform _scaleRoot;
	[SerializeField]
	private SandLevelController _caveTwinSandLevel;
	[SerializeField]
	private SandLevelController _towerTwinSandLevel;
	[SerializeField]
	private GameObject[] _sandGeoObjects;
	[SerializeField]
	private Transform _caveTwinEffectsRoot;
	[SerializeField]
	private Transform _towerTwinEffectsRoot;
	[SerializeField]
	private OWAudioSource[] _audioSources;
	[SerializeField]
	private OWTriggerVolume _lakebedCaveVolume;
	[SerializeField]
	private OWRenderer[] _sandRenderers;
	[SerializeField]
	private Transform _hgtTowerTransform;
	[SerializeField]
	private Sector _particleCullSector;
}
