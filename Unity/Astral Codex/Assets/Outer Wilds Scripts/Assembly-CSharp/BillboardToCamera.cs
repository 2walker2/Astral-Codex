using UnityEngine;

public class BillboardToCamera : SectoredMonoBehaviour
{
	private enum RotationType
	{
		FREE_ROTATION = 0,
		ROTATE_ABOUT_X_AXIS = 1,
		ROTATE_ABOUT_Y_AXIS = 2,
	}

	[SerializeField]
	private RotationType _rotationType;
}
