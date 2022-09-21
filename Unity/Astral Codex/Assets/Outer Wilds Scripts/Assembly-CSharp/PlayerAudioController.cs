using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource _oneShotExternalSource;
	[SerializeField]
	private OWAudioSource _oneShotSleepingAtCampfireSource;
	[SerializeField]
	private OWAudioSource _mapTrackSource;
	[SerializeField]
	private OWAudioSource _repairToolSource;
	[SerializeField]
	private OWAudioSource _translatorSource;
	[SerializeField]
	private OWAudioSource _damageAudioSource;
	[SerializeField]
	private OWAudioSource _damageAudioSourceExternal;
	[SerializeField]
	private OWAudioSource _notificationAudio;
	[SerializeField]
	private OWAudioSource _fluidVolumeSource;
	[SerializeField]
	private OWAudioSource _forceVolumeAudio;
	[SerializeField]
	private OWAudioSource _oxygenLeakSource;
	[SerializeField]
	private OWAudioSource _recorderLoopSource;
	[SerializeField]
	private OWAudioSource _sleepingAtCampfireSource;
	[SerializeField]
	private NomaiTextRevealAudioController[] _nomaiTextAudioControllers;
}
