using UnityEngine;

public class DreamRiverFluidVolume : FlatFluidVolume
{
	[SerializeField]
	private float _defaultSpeed;
	[SerializeField]
	private float _densityForRaft;
	[SerializeField]
	private AnimationCurve _attractCurve;
	[SerializeField]
	private RiverFlowRail _rail;
}
