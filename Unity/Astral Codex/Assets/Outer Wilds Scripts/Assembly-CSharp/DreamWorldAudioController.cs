using UnityEngine;

public class DreamWorldAudioController : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource _waveSource;
	[SerializeField]
	private OWAudioSource _solarSailSource;
	[SerializeField]
	private OWAudioSource _libraryMusicSource;
	[SerializeField]
	private AnimationCurve _waveVolumeCurve;
	[SerializeField]
	private AudioVolume _simulationAmbience;
	[SerializeField]
	private AudioVolume _loadingTunnelAmbience;
	[SerializeField]
	private DreamWorldController _dreamWorldController;
	[SerializeField]
	private OWTriggerVolume[] _libraryMusicTriggers;
	[SerializeField]
	private DreamRiverPathAudioController _riverPathAudioController;
	[SerializeField]
	private DreamRiverPathAudioController _lakePathAudioController;
}
