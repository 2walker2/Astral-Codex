using UnityEngine;

public class NomaiMultiPartDoor : NomaiRotator
{
	protected enum StartingRotationState
	{
		OPEN = 0,
		CLOSED = 1,
	}

	protected enum CycleType
	{
		POSITIVE_OPENCLOSE = 0,
		NEGATIVE_OPENCLOSE = 1,
		POS_OPEN_NEG_CLOSE = 2,
		NEG_OPEN_POS_CLOSE = 3,
	}

	[SerializeField]
	protected NomaiInterfaceOrb[] _listInterfaceOrb;
	[SerializeField]
	protected StartingRotationState _rotationOnStart;
	[SerializeField]
	protected CycleType _cycleType;
	[SerializeField]
	protected RotationObject[] _rotationObjectList;
}
