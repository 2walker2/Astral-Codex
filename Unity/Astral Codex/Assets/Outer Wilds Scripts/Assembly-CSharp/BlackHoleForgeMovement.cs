using UnityEngine;

public class BlackHoleForgeMovement : MonoBehaviour
{
	[SerializeField]
	private float _movingLength;
	[SerializeField]
	private GameObject _lowerPosition;
	[SerializeField]
	private GameObject _midPosition;
	[SerializeField]
	private GameObject _highPosition;
	[SerializeField]
	private float _lowerPositionOffset;
	[SerializeField]
	private float _midPositionOffset;
	[SerializeField]
	private float _highPositionOffset;
	[SerializeField]
	private AnimationCurve _movingCurve;
	[SerializeField]
	private AnimationCurve _rotationCurve;
	[SerializeField]
	private NomaiInterfaceSlot[] _lowerSwitches;
	[SerializeField]
	private NomaiInterfaceSlot[] _middleSwitches;
	[SerializeField]
	private NomaiInterfaceSlot[] _higherSwitches;
	[SerializeField]
	private float _lowerRotation;
	[SerializeField]
	private float _midRotation;
	[SerializeField]
	private float _highRotation;
}
