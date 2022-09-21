using UnityEngine;

public class NightLight : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _emissiveRenderers;
	[SerializeField]
	private float _dayLightIntensityMultiplier;
	[SerializeField]
	private float _dayEmissionIntensityMultiplier;
	[SerializeField]
	private float _fadeLength;
}
