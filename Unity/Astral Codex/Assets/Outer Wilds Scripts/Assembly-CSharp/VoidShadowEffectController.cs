using UnityEngine;

public class VoidShadowEffectController : MonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _objectRenderers;
	[SerializeField]
	private OWRenderer[] _objectVoidShadowRenderers;
	[SerializeField]
	private AnimationCurve _objectDissolveCurve;
	[SerializeField]
	private Transform _voidCracksParent;
	[SerializeField]
	private Vector3 _voidCracksParentOffset;
}
