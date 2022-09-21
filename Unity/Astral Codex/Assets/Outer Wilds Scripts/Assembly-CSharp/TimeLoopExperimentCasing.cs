using UnityEngine;

public class TimeLoopExperimentCasing : MonoBehaviour
{
	[SerializeField]
	private float _movingLength;
	[SerializeField]
	private GameObject _lowerPosition;
	[SerializeField]
	private GameObject _highPosition;
	[SerializeField]
	private AnimationCurve _movingCurve;
	[SerializeField]
	private NomaiInterfaceSlot[] _lowerSwitches;
	[SerializeField]
	private NomaiInterfaceSlot[] _higherSwitches;
}
