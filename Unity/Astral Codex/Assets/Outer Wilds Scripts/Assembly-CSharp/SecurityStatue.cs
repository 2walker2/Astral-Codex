using UnityEngine;

public class SecurityStatue : MonoBehaviour
{
	[SerializeField]
	private VisionSensor _visionSensor;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private Material _alertMaterial;
	[SerializeField]
	private MeshRenderer _alertRenderer;
}
