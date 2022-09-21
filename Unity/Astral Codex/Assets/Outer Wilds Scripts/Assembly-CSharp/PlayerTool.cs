using UnityEngine;

public class PlayerTool : MonoBehaviour
{
	[SerializeField]
	protected DampedSpringQuat _moveSpring;
	[SerializeField]
	protected Transform _stowTransform;
	[SerializeField]
	protected Transform _holdTransform;
	[SerializeField]
	protected float _arrivalDegrees;
}
