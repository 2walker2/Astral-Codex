using UnityEngine;

public class TranslatorScanBeam : MonoBehaviour
{
	[SerializeField]
	private Renderer _projectorRenderer;
	[SerializeField]
	private Renderer _lightVolumeRenderer;
	[SerializeField]
	private float _focusedBeamWidth;
	[SerializeField]
	private float _maxBeamWidth;
	[SerializeField]
	private float _maxBeamLength;
	[SerializeField]
	private float _scanSpeed;
	[SerializeField]
	private float _scanOffset;
	[SerializeField]
	private float _switchLength;
	[SerializeField]
	private float _fadeLength;
}
