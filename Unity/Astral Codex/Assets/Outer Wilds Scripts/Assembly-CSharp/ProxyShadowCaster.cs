using UnityEngine;

public class ProxyShadowCaster : MonoBehaviour
{
	[SerializeField]
	private ProxyShadowCascade.Flags _cascadeFlags;
	[SerializeField]
	private bool _earlyDraw;
	[SerializeField]
	private bool _dynamic;
}
