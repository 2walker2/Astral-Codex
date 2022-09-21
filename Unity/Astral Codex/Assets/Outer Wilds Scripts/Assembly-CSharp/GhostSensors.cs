using UnityEngine;

public class GhostSensors : MonoBehaviour
{
	[SerializeField]
	private Transform _sightOrigin;
	[SerializeField]
	private DreamLanternController _lantern;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWTriggerVolume _contactTrigger;
	[SerializeField]
	private BoxShape _contactEdgeCatcherShape;
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private float _grabDistanceBuff;
	[SerializeField]
	private float _grabAngleBuff;
}
