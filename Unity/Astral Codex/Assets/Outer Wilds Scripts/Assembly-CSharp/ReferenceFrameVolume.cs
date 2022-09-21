using UnityEngine;

public class ReferenceFrameVolume : MonoBehaviour
{
	[SerializeField]
	protected ReferenceFrame _referenceFrame;
	[SerializeField]
	protected float _minColliderRadius;
	[SerializeField]
	protected float _maxColliderRadius;
	[SerializeField]
	protected bool _isPrimaryVolume;
	[SerializeField]
	protected bool _isCloseRangeVolume;
}
