using UnityEngine;

public class TornadoController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _underwaterVolume;
	[SerializeField]
	private bool _snapBonesToSphere;
	[SerializeField]
	private bool _wander;
	[SerializeField]
	private float _wanderRate;
	[SerializeField]
	private float _wanderDegreesX;
	[SerializeField]
	private float _wanderDegreesZ;
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private GameObject _tornadoRoot;
	[SerializeField]
	private FluidVolume[] _fluids;
	[SerializeField]
	private OWTriggerVolume _collapseTrigger;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private Transform _topBone;
	[SerializeField]
	private Transform _midBone;
	[SerializeField]
	private Transform _bottomBone;
	[SerializeField]
	private Renderer[] _topBlendRenderers;
	[SerializeField]
	private Renderer[] _bodyRenderers;
	[SerializeField]
	private Renderer[] _bottomBlendRenderers;
	[SerializeField]
	private float _topFadeTime;
	[SerializeField]
	private float _bodyFadeTime;
	[SerializeField]
	private float _bottomFadeTime;
	[SerializeField]
	private float _topScaleAmplitude;
	[SerializeField]
	private float _topScaleFrequency;
	[SerializeField]
	private float _midScaleAmplitude;
	[SerializeField]
	private float _midScaleFrequency;
	[SerializeField]
	private float _bottomScaleAmplitude;
	[SerializeField]
	private float _bottomScaleFrequency;
	[SerializeField]
	private float _rotationSpeed;
	[SerializeField]
	private float _midRotationAmplitude;
	[SerializeField]
	private Vector2 _midRotationXZFrequency;
}
