using UnityEngine;

public class NomaiLamp : MonoBehaviour
{
	[SerializeField]
	private bool _startOn;
	[SerializeField]
	private Renderer[] _emissiveRenderers;
	[SerializeField]
	private int _materialIndex;
}
