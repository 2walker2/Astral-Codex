using UnityEngine;

public class VisionDetector : MonoBehaviour
{
	private enum Name
	{
		Default = 0,
		Player = 1,
		Probe = 2,
	}

	[SerializeField]
	private Name _name;
	[SerializeField]
	private float _illuminationRadius;
	[SerializeField]
	private Vector3 _localIlluminationOffset;
}
