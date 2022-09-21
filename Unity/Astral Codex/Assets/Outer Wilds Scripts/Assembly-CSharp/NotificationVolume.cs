using UnityEngine;

public class NotificationVolume : EffectVolume
{
	public enum Type
	{
		None = 0,
		DarkMatter = 1,
	}

	[SerializeField]
	private Type _type;
}
