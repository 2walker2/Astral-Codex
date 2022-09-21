using UnityEngine;

public class AlarmBridgeController : MonoBehaviour
{
	[SerializeField]
	private AbstractGhostDoorInterface _codeInterface;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRendererFadeController _lightBeamController;
}
