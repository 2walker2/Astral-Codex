using System;

[Serializable]
public class InputRebindableData
{
	public InputRebindableData(bool init)
	{
	}

	public int version;
	public InputRebindable[] rebindableList;
	public InputUtil.GamePadPresetConfig gamepadConfig;
	public InputUtil.ButtonPromptPresetConfig promptConfig;
	public string lastUsedDeviceName;
	public int lastUsedDeviceIndex;
}
