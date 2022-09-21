using UnityEngine;

public class IceMeltController : MonoBehaviour
{
	[SerializeField]
	private float _startMeltDistance;
	[SerializeField]
	private float _endMeltDistance;
	[SerializeField]
	private Transform _surfaceIce;
	[SerializeField]
	private Transform _surfaceIceProxy;
	[SerializeField]
	private float _surfaceIceMeltedScale;
	[SerializeField]
	private SkinnedMeshRenderer _crackIce;
	[SerializeField]
	private AnimationCurve[] _blendWeightCurves;
	[SerializeField]
	private Transform[] _crackIceColliders;
	[SerializeField]
	private AnimationCurve _colliderScaleCurve;
	[SerializeField]
	private AudioVolume _audioVolume;
}
