using UnityEngine;

public class FogWarpDetector : MonoBehaviour
{
	public enum Name
	{
		None = 0,
		Player = 1,
		Ship = 2,
		Probe = 3,
	}

	[SerializeField]
	protected Name _name;
}
