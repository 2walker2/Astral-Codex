using UnityEngine;

public class VisibilityObject : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _checkIllumination;
	[SerializeField]
	private float _illuminationRadius;
	[SerializeField]
	private Vector3 _localIlluminationOffset;
}
