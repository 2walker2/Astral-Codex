using UnityEngine;

public class RaftPinwheelController : MonoBehaviour
{
	[SerializeField]
	private Transform _rudderPivot;
	[SerializeField]
	private DreamTorch _torch;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private ForceDetector _forceDetector;
	[SerializeField]
	private MeshRenderer[] _panelRenderers;
	[SerializeField]
	private Material _glowMaterial;
}
