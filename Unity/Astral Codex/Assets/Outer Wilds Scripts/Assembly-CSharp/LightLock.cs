using UnityEngine;

public class LightLock : MonoBehaviour
{
	[SerializeField]
	private Material _glowMaterial;
	[SerializeField]
	private Material _origMaterial;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private Transform[] _lockTransforms;
	[SerializeField]
	private MeshRenderer[] _lockRenderers;
}
