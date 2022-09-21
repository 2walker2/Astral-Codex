using UnityEngine;

public class NomaiRecorderEffects : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _ringRenderers;
	[SerializeField]
	private int[] _materialIndexes;
	[SerializeField]
	private float[] _scrollSpeeds;
	[SerializeField]
	private OWAudioSource _audioSource;
}
