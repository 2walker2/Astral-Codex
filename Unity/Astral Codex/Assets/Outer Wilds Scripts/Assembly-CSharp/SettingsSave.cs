using System;

[Serializable]
public class SettingsSave
{
	[Serializable]
	public struct UserDeviceInfo
	{
		public bool userEnabled;
		public string unityDeviceName;
		public int productId;
		public int vendorId;
		public string manufacturer;
		public string productName;
	}

	public bool autoBoost;
	public bool autoRun;
	public bool autoEquipTranslator;
	public TextSpeed textSpeed;
	public bool freezeTimeWhileReading;
	public bool showShipLogNotifications;
	public bool detectiveModeEnabled;
	public int inversionFactor;
	public int lookSensitivity;
	public int flightSensitivity;
	public Difficulty difficulty;
	public bool autopilotEnabled;
	public bool buttonPromptsEnabled;
	public bool reducedFrights;
	public int shipInversionFactor;
	public bool rumbleEnabled;
	public ButtonPromptImgSet promptImgSet;
	public UserDeviceInfo[] deviceEnabledList;
	public TextTranslation.Language language;
	public bool freezeTimeWhileReadingShipLog;
	public bool freezeTimeWhileReadingConversations;
	public float innerDeadZone;
	public float outerDeadZone;
	public float masterVolume;
	public float musicVolume;
	public float sfxVolume;
}
