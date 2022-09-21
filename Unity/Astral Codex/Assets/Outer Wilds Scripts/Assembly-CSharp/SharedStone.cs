using UnityEngine;

public class SharedStone : OWItem
{
	[SerializeField]
	private NomaiRemoteCameraPlatform.ID _connectedPlatform;
	[SerializeField]
	private TransformAnimator _animator;
}
