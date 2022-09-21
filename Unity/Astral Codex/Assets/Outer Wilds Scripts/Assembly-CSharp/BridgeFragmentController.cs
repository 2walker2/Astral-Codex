using UnityEngine;

public class BridgeFragmentController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private Transform _snapTarget;
	[SerializeField]
	private bool _reattachAfterSettle;
	[SerializeField]
	private Shape _detectorShape;
}
