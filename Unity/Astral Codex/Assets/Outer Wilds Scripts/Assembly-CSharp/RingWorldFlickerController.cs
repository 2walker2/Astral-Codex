using UnityEngine;

public class RingWorldFlickerController : MonoBehaviour
{
	[SerializeField]
	private OWLight2[] _lights;
	[SerializeField]
	private GameObject _lightsRoot;
	[SerializeField]
	private OWEmissiveRenderer[] _renderers;
	[SerializeField]
	private GameObject _renderersRoot;
}
