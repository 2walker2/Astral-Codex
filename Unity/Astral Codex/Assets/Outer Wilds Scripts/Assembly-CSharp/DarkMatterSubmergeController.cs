using UnityEngine;

public class DarkMatterSubmergeController : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _activeWhenSubmerged;
	[SerializeField]
	private EffectVolume[] _effectVolumes;
	[SerializeField]
	private OWRenderer[] _renderers;
	[SerializeField]
	private ConstantFluidDetector _fluidDetector;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
}
