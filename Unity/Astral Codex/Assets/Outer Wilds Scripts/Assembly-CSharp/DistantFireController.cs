using UnityEngine;

public class DistantFireController : MonoBehaviour
{
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private GameObject[] _objectsToDeactivate;
}
