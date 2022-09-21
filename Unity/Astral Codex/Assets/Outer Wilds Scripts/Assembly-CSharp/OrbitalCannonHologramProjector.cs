using UnityEngine;

public class OrbitalCannonHologramProjector : HologramProjector
{
	[SerializeField]
	private NomaiInterfaceSlot[] _slots;
	[SerializeField]
	private GameObject[] _holograms;
	[SerializeField]
	private NomaiComputer[] _computers;
	[SerializeField]
	private NomaiEnergyCable[] _energyCables;
}
