using UnityEngine;

public class OWCollider : MonoBehaviour
{
	[SerializeField]
	private DynamicOccupantMask _lodActivationMask;
	[SerializeField]
	private bool _ignorePhysicsSwapDelay;
	[SerializeField]
	private bool _drawBounds;
	[SerializeField]
	private bool _doNotStream;
}
