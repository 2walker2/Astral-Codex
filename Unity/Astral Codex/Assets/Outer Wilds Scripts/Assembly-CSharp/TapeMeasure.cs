using UnityEngine;

public class TapeMeasure : MonoBehaviour
{
	[SerializeField]
	private Transform _toTransform;
	[SerializeField]
	private bool _printDistanceFromTarget;
	[SerializeField]
	private bool _printDeltaFromStart;
	[SerializeField]
	private bool _printRateOfChange;
	[SerializeField]
	private bool _useCentersOfMass;
	[SerializeField]
	private bool _recordPositions;
	[SerializeField]
	private float _positionRecordingInterval;
	[SerializeField]
	private bool _drawPositionTrail;
}
