using UnityEngine;

public class MindProjectorTrigger : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private bool _deactivateOnCompletion;
	[SerializeField]
	private Transform _lockOnTransform;
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private MindSlideProjector _mindProjector;
	[SerializeField]
	private bool _useCurve;
	[SerializeField]
	private AnimationCurve _intensityCurve;
	[SerializeField]
	private OWRendererFadeController _lightRayFadeController;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWFlameController _flameController;
	[SerializeField]
	private ParticleSystem[] _particles;
	[SerializeField]
	private Transform _scanBeamTransform;
	[SerializeField]
	private OWRendererFadeController _scanBeamFadeController;
	[SerializeField]
	private OWLightController _scanLightController;
	[SerializeField]
	private OWAudioSource _scanSource;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private OWAudioSource _loopingSource;
}
