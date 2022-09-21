using UnityEngine;

public class NomaiWarpReceiver : NomaiWarpPlatform
{
	[SerializeField]
	private Transform _alignmentTarget;
	[SerializeField]
	private OWRendererFadeController _returnGlowFadeController;
	[SerializeField]
	private OWTriggerVolume _returnTrigger;
}
