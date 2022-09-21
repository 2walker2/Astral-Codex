using UnityEngine;

public class QuantumMoon : QuantumObject
{
	[SerializeField]
	private float _fogRadius;
	[SerializeField]
	private float _fogThickness;
	[SerializeField]
	private float _fogRolloffDistance;
	[SerializeField]
	private float _eyeStateFogOffset;
	[SerializeField]
	private GameObject[] _deactivateAtEye;
	[SerializeField]
	private OWCollider _noStateGroundCollider;
	[SerializeField]
	private Transform _outerCloudTransform;
	[SerializeField]
	private FogOverrideVolume _fogOverride;
	[SerializeField]
	private SunOverrideVolume _sunOverride;
	[SerializeField]
	private AudioSignal _quantumSignal;
	[SerializeField]
	private ReferenceFrameVolume _referenceFrameVolume;
	[SerializeField]
	private Transform _vortexReturnPivot;
	[SerializeField]
	private SphereShape _interiorVolumeShape;
	[SerializeField]
	private OWAudioSource _vortexAudio;
	[SerializeField]
	private Transform _probeAnchorPoint;
	[SerializeField]
	private OWTriggerVolume _probeShipTrigger;
	[SerializeField]
	private SphereShape _sectorShape;
	[SerializeField]
	private VisibilityTracker _visibilityTracker;
	[SerializeField]
	private QuantumShrine _shrine;
	[SerializeField]
	private GameObject[] _quantumShrineProxyRenderers;
	[SerializeField]
	private float _sphereCheckRadius;
	[SerializeField]
	private GameObject[] _states;
	[SerializeField]
	private QuantumDarkTrigger[] _darkTriggers;
	[SerializeField]
	private string _revealFactID;
}
