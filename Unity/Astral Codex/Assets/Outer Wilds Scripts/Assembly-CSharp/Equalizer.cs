using UnityEngine;

public class Equalizer : MonoBehaviour
{
	[SerializeField]
	private Renderer[] _barRenderers;
	[SerializeField]
	private AnimationCurve[] _waveforms;
	[SerializeField]
	private float _waveformSpeed;
	[SerializeField]
	private float _waveformMagnitude;
	[SerializeField]
	private float _noiseSpeed;
	[SerializeField]
	private float _noiseMagnitude;
}
