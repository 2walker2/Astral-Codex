using UnityEngine;

public class DreamLanternController : MonoBehaviour
{
	[SerializeField]
	private float _minRange;
	[SerializeField]
	private float _maxRange;
	[SerializeField]
	private float _minAngle;
	[SerializeField]
	private float _maxAngle;
	[SerializeField]
	private GameObject _worldModelGroup;
	[SerializeField]
	private GameObject _viewModelGroup;
	[SerializeField]
	private OWLight2 _light;
	[SerializeField]
	private OWRenderer[] _flameRenderers;
	[SerializeField]
	private OWLight2[] _flameLights;
	[SerializeField]
	private LensFlare _lensFlare;
	[SerializeField]
	private LightFlicker2 _flicker;
	[SerializeField]
	private Transform _focuserGroup;
	[SerializeField]
	private Transform[] _focuserPetals;
	[SerializeField]
	private Transform[] _concealerRoots;
	[SerializeField]
	private Transform[] _concealerCovers;
	[SerializeField]
	private Transform[] _concealerCoversVMPrepass;
	[SerializeField]
	private Vector3[] _concealerCoverTargets;
	[SerializeField]
	private GameObject _simLightConeUnfocused;
	[SerializeField]
	private GameObject _simLightConeFocused;
}
