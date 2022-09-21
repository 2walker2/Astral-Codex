using UnityEngine;

public class LightFlicker : SectoredMonoBehaviour
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[SerializeField]
	private float _range;
	[SerializeField]
	private float _rate;
}
