using UnityEngine;

public class DreamWorldGravityController : MonoBehaviour
{
	[SerializeField]
	private DirectionalForceVolume _forceVolume;
	[SerializeField]
	private AnimationCurve _stageOneCurve;
	[SerializeField]
	private AnimationCurve _stageTwoCurve;
	[SerializeField]
	private Vector3 _localTiltAxis;
}
