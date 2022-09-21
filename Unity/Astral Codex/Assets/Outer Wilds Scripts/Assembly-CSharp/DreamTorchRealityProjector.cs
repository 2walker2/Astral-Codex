using UnityEngine;

public class DreamTorchRealityProjector : MonoBehaviour
{
	[SerializeField]
	private DreamTorch _dreamTorch;
	[SerializeField]
	private GameObject _lightRoot;
	[SerializeField]
	private GameObject _darkRoot;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWLightController _lightController;
}
