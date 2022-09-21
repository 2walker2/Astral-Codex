using UnityEngine;
using UnityEngine.Rendering;

public class PerCameraRendererState : MonoBehaviour
{
	[SerializeField]
	private OWCamera _owCamera;
	[SerializeField]
	private bool _enabled;
	[SerializeField]
	private ShadowCastingMode _shadowCastingMode;
}
