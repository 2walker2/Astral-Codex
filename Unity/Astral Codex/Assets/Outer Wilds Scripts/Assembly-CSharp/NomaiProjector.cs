using UnityEngine;

public class NomaiProjector : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _controllingSlot;
	[SerializeField]
	private MeshRenderer[] _textRenderers;
	[SerializeField]
	private float _fadeLength;
	[SerializeField]
	private float _startDelay;
	[SerializeField]
	private float _staggerDelay;
	[SerializeField]
	private bool _startVisible;
}
