using UnityEngine;

public class QuantumObject : VisibilityObject
{
	[SerializeField]
	protected float _maxSnapshotLockRange;
	[SerializeField]
	protected bool _collapseOnStart;
	[SerializeField]
	protected bool _debug;
	[SerializeField]
	protected bool _ignoreRetryQueue;
}
