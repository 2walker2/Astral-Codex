using UnityEngine;

public class Campfire : MonoBehaviour
{
	public enum State
	{
		UNLIT = 0,
		LIT = 1,
		SMOLDERING = 2,
	}

	[SerializeField]
	private State _initialState;
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private bool _canSleepHere;
	[SerializeField]
	private bool _lookUpWhileSleeping;
	[SerializeField]
	private float _heatConeBottom;
	[SerializeField]
	private float _heatConeTop;
	[SerializeField]
	private float _heatConeRadius;
	[SerializeField]
	private float _heatFalloffDistance;
	[SerializeField]
	private float _logSphereCenter;
	[SerializeField]
	private float _logSphereRadius;
	[SerializeField]
	private float _rockHeight;
	[SerializeField]
	protected OWAudioSource _audio;
	[SerializeField]
	protected OWAudioSource _oneShotAudio;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRenderer[] _litRenderers;
	[SerializeField]
	private OWRenderer[] _hideWhileSmolderingRenderers;
	[SerializeField]
	private ParticleSystem[] _smolderingParticles;
	[SerializeField]
	private ParticleSystem[] _litParticles;
	[SerializeField]
	private MeshRenderer _flames;
	[SerializeField]
	private MeshRenderer _embers;
	[SerializeField]
	private MeshRenderer _ash;
	[SerializeField]
	private SingleInteractionVolume _interactVolume;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private HazardVolume _hazardVolume;
	[SerializeField]
	private Transform _burnedSlideReelSocket;
}
