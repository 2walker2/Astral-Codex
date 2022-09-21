using UnityEngine;

public class LightSwitchInterfaceOrb : LightSwitch
{
	private enum SlotAction
	{
		NONE = 0,
		TURN_ON = 1,
		TURN_OFF = 2,
	}

	[SerializeField]
	private NomaiInterfaceSlot[] _slotsGroup1;
	[SerializeField]
	private SlotAction _group1SlotActivateAction;
	[SerializeField]
	private SlotAction _group1SlotDectivateAction;
	[SerializeField]
	private NomaiInterfaceSlot[] _slotsGroup2;
	[SerializeField]
	private SlotAction _group2SlotActivateAction;
	[SerializeField]
	private SlotAction _group2SlotDeactivateAction;
}
