using UnityEngine;

public class RoastingStickController : MonoBehaviour
{
	[SerializeField]
	private Transform _stickPivotTransform;
	[SerializeField]
	private Transform _stickTransform;
	[SerializeField]
	private Marshmallow _marshmallow;
	[SerializeField]
	private GameObject _mallowBodyPrefab;
	[SerializeField]
	private GameObject _unsuitedRoastingArm;
	[SerializeField]
	private GameObject _suitedRoastingArm;
}
