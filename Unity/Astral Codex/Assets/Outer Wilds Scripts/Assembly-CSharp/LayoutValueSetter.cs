using UnityEngine;

public class LayoutValueSetter : MonoBehaviour
{
	public enum SetterType
	{
		NONE = 0,
		OWN_HEIGHT_DRIVES_WIDTH = 1,
	}

	[SerializeField]
	private SetterType _setterType;
}
