using UnityEngine;

public class DreamLanternItem : OWItem
{
	[SerializeField]
	private DreamLanternType _lanternType;
	[SerializeField]
	private bool _startLit;
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
