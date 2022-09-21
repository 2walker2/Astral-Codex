using System;

[Serializable]
public class InputRebindable
{
	public enum InputType
	{
		UNDEFINED = 0,
		BUTTON = 1,
		BINARY_AXIS = 2,
		ANALOG_AXIS = 3,
		ANALOG_AXIS_ZERO_TO_ONE = 4,
	}

	public enum AxisDirection
	{
		UNDEFINED = 0,
		HORIZONTAL = 1,
		VERTICAL = 2,
	}

	public InputRebindable(RebindableID id, InputRebindable.InputType inputType, InputRebindable.AxisDirection direction)
	{
	}

}
