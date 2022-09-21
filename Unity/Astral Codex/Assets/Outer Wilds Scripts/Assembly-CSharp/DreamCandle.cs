using UnityEngine;

public class DreamCandle : MonoBehaviour
{
	[SerializeField]
	private bool _startLit;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private AudioType _lightClip;
}
