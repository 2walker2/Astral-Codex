using System;

[Serializable]
public class GamePadConfig
{
	public GamePadConfig(InputUtil.GamePadPresetConfig configType)
	{
	}

	public string gamepadHardwareName;
	public InputUtil.GamePadPresetConfig originalPreset;
	public InputUtil.ButtonPromptPresetConfig buttonPromptType;
}
