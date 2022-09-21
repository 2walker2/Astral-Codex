using UnityEngine;

public class IslandController : MonoBehaviour
{
	public bool debug;
	[SerializeField]
	private FluidVolume _inheritanceFluid;
	[SerializeField]
	private FluidVolume[] _barrierRepelFluids;
	[SerializeField]
	private ForceVolume _zeroGVolume;
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private SafetyTractorBeamController[] _safetyTractorBeams;
	[SerializeField]
	private Campfire _campfire;
}
