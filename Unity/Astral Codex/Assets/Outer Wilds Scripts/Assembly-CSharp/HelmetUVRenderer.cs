using UnityEngine;

public class HelmetUVRenderer : MonoBehaviour
{
	[SerializeField]
	private OWCamera _targetCamera;
	[SerializeField]
	private Renderer[] _renderers;
	[SerializeField]
	private float _removeHelmetDelay;
}
