using UnityEngine;

public class ShipHeadlightComponent : ShipComponent
{
	[SerializeField]
	protected ElectricalSystem _electricalSystem;
	[SerializeField]
	protected ShipLight[] _headlights;
	[SerializeField]
	protected float _disruptionImpactSpeed;
	[SerializeField]
	protected float _disruptionLength;
}
