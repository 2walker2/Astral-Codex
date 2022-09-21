using UnityEngine;

public class ProxyShadowCasterGroup : MonoBehaviour
{
	[SerializeField]
	private ProxyShadowCascade.Flags _cascadeFlags;
	[SerializeField]
	private bool _earlyDraw;
	[SerializeField]
	private bool _dynamic;
}
