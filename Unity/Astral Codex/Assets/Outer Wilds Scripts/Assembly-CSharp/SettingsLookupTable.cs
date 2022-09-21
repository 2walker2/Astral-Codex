using UnityEngine;
using System;

public class SettingsLookupTable : ScriptableObject
{
	[Serializable]
	public struct SettingsEntry
	{
		public SettingsEntry(SettingsID sId, UITextType label, UITextType tooltip) : this()
		{
		}

		public SettingsID settingsId;
		public RebindableID rebindableId;
		public UITextType labelTextType;
		public UITextType tooltipTextType;
	}

	public SettingsEntry[] settingsEntries;
}
