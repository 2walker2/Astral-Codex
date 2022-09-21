using UnityEngine;

public class ThrusterModel : MonoBehaviour
{
	[SerializeField]
	protected float _maxTranslationalThrust;
	[SerializeField]
	protected float _maxRotationalThrust;
	[SerializeField]
	protected float _angularDrag;
	[SerializeField]
	protected bool _usePhysicsToRotate;
}
