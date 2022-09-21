using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
	[SerializeField]
	private GameObject _unsuitedGroup;
	[SerializeField]
	private GameObject _suitedGroup;
	[SerializeField]
	private GameObject[] _rightArmObjects;
	[SerializeField]
	private AnimatorOverrideController _unsuitedAnimOverride;
}
