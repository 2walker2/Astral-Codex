using UnityEngine;

public class DetachableConnector : DetachableFragment
{
	[SerializeField]
	private FragmentIntegrity[] _connectedFragments;
	[SerializeField]
	private int _minSupportCount;
	[SerializeField]
	private float _detachAtIntegrity;
}
