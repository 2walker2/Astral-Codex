using UnityEngine;

public class ProbeCamera : MonoBehaviour
{
	public enum ID
	{
		Forward = 0,
		Reverse = 1,
		PreLaunch = 2,
		Rotating = 3,
	}

	[SerializeField]
	private ID _id;
}
