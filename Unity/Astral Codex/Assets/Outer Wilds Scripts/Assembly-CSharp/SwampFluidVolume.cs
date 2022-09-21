using UnityEngine;

public class SwampFluidVolume : FlatFluidVolume_Old
{
	[SerializeField]
	private float _depth;
	[SerializeField]
	private float _heightChange;
	[SerializeField]
	private float _changeOverDegrees;
	[SerializeField]
	private bool _previewNightOnHeads;
	[SerializeField]
	private Transform _surfaceHeads;
	[SerializeField]
	private Transform _surfaceTails;
}
