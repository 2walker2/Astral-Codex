using UnityEngine;

public class ShipLight : ElectricalComponent
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[SerializeField]
	private float _fadeLength;
}
