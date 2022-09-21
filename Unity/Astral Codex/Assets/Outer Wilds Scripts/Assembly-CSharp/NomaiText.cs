using UnityEngine;

public class NomaiText : SectoredMonoBehaviour
{
	public enum Location
	{
		UNSPECIFIED = 0,
		A = 1,
		B = 2,
	}

	[SerializeField]
	protected float _interactRange;
	[SerializeField]
	protected TextAsset _nomaiTextAsset;
	[SerializeField]
	protected Location _location;
}
