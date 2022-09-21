using UnityEngine;

public class DreamObjectProjector : MonoBehaviour
{
	[SerializeField]
	protected bool _startLit;
	[SerializeField]
	protected bool _extinguishOnly;
	[SerializeField]
	protected DreamObjectProjection[] _projections;
	[SerializeField]
	protected DreamObjectProjector[] _extinguishedProjectors;
	[SerializeField]
	protected AudioVolume[] _lightsOutAudioVolumes;
	[SerializeField]
	protected DreamCandle[] _dreamCandles;
	[SerializeField]
	protected LightSensor _lightSensor;
	[SerializeField]
	protected InteractReceiver _interactReceiver;
	[SerializeField]
	protected OWTriggerVolume _triggerVolume;
	[SerializeField]
	protected OWFlameController _flameController;
	[SerializeField]
	protected AlarmTotem _alarmTotem;
	[SerializeField]
	private OWAudioSource _farOneShotSource;
	[SerializeField]
	private OWAudioSource _closeOneShotSource;
}
