using UnityEngine;

public class DebugFlowFieldVisualizer : MonoBehaviour
{
	[SerializeField]
	private bool _drawFlowVectors;
	[SerializeField]
	private bool _drawFlowMarkers;
	[SerializeField]
	private int _xResolution;
	[SerializeField]
	private int _yResolution;
	[SerializeField]
	private float _velocityScale;
	[SerializeField]
	private bool _updateFlowVectors;
	[SerializeField]
	private bool _debugToggleFlood;
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private OWRingRiverCollider _riverCollider;
	[SerializeField]
	private RingRiverController _riverController;
}
