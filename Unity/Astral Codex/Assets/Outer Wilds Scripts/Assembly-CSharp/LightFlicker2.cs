using UnityEngine;

public class LightFlicker2 : SectoredMonoBehaviour
{
	[SerializeField]
	private OWLight2[] _lights;
	[SerializeField]
	private OWEmissiveRenderer[] _renderers;
	[SerializeField]
	private float _range;
	[SerializeField]
	private float _rate;
}
