using UnityEngine;

public class RendererVisibilityTracker : VisibilityTracker
{
	[SerializeField]
	private Collider[] _ignoreOcclusionColliders;
	[SerializeField]
	private bool _checkOcclusion;
	[SerializeField]
	private bool _checkFrustumOcclusion;
}
