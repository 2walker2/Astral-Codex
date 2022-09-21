using System;
using UnityEngine;

[Serializable]
public class InputBinding
{
	public KeyCode positiveKey;
	public KeyCode negativeKey;
	public string unityJoystickAxisName;
	public AxisIdentifier axisID;
	public int displayDirection;
	public int axisDirection;
	public JoystickButton gamepadButtonPos;
	public JoystickButton gamepadButtonNeg;
}
