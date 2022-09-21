using UnityEngine;

public class SingleSlideProjector : MonoBehaviour
{
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRendererFadeController _lightShaftController;
	[SerializeField]
	private OWLightController _bounceLightController;
	[SerializeField]
	private OWCollider _shipLogTriggerCollider;
}
