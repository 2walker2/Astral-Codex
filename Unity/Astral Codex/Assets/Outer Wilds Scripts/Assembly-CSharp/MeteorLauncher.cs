using UnityEngine;

public class MeteorLauncher : MonoBehaviour
{
	[SerializeField]
	private GameObject _meteorPrefab;
	[SerializeField]
	private GameObject _dynamicMeteorPrefab;
	[SerializeField]
	private float _dynamicProbability;
	[SerializeField]
	private float _minLaunchSpeed;
	[SerializeField]
	private float _maxLaunchSpeed;
	[SerializeField]
	private float _minInterval;
	[SerializeField]
	private float _maxInterval;
	[SerializeField]
	private Vector3 _launchDirection;
	[SerializeField]
	private ParticleSystem[] _launchParticles;
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private OWAudioSource _launchSource;
	[SerializeField]
	private ForceVolume _detectableField;
	[SerializeField]
	private FluidVolume _detectableFluid;
}
