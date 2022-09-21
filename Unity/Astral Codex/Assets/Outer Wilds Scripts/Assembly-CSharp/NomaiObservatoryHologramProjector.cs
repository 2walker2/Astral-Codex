using UnityEngine;

public class NomaiObservatoryHologramProjector : HologramProjector
{
	[SerializeField]
	private NomaiInterfaceSlot[] _slots;
	[SerializeField]
	private GameObject _hologramPrefab;
	[SerializeField]
	private NomaiComputer _eyeComputer;
}
