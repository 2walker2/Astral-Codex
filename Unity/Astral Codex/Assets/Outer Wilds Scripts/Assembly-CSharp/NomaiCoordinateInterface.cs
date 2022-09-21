using UnityEngine;

public class NomaiCoordinateInterface : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource _loopingSource;
	[SerializeField]
	private Transform _basePivot;
	[SerializeField]
	private Transform _pillarRoot;
	[SerializeField]
	private int[] _coordinateX;
	[SerializeField]
	private int[] _coordinateY;
	[SerializeField]
	private int[] _coordinateZ;
	[SerializeField]
	private NomaiNodeController[] _nodeControllers;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private NomaiInterfaceOrb _upperOrb;
	[SerializeField]
	private NomaiInterfaceSlot[] _rotateSlots;
	[SerializeField]
	private TransformAnimator[] _gateAnimators;
	[SerializeField]
	private NomaiInterfaceSlot _lowerPillarSlot;
	[SerializeField]
	private NomaiInterfaceSlot _raisePillarSlot;
	[SerializeField]
	private float _loweredHeight;
}
