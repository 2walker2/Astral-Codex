using UnityEngine;

public class TractorBeamSwitch : MonoBehaviour
{
	public enum State
	{
		OFF = 0,
		FORWARD = 1,
		REVERSE = 2,
	}

	[SerializeField]
	private State _initialState;
	[SerializeField]
	private TractorBeamController[] _tractorBeams;
	[SerializeField]
	private TractorBeamSwitch[] _linkedSwitches;
	[SerializeField]
	private NomaiInterfaceSlot _forwardSlot;
	[SerializeField]
	private NomaiInterfaceSlot _reverseSlot;
	[SerializeField]
	private NomaiInterfaceSlot _offSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
}
