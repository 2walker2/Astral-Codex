using UnityEngine;

public class ProbePhotoTarget : VisibilityObject
{
	[SerializeField]
	private float _maxPhotoDistance;
	[SerializeField]
	private float _baseScore;
	[SerializeField]
	private string _name;
	[SerializeField]
	private float _raycastOffset;
}
