using UnityEngine;

public class PictureFrameDoorInterface : MonoBehaviour
{
	[SerializeField]
	private InteractReceiver[] _interactReceivers;
	[SerializeField]
	protected RotatingDoor _door;
	[SerializeField]
	private string[] _revealFactIDs;
}
