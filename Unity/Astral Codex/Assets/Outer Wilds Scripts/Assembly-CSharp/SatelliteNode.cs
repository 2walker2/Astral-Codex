using UnityEngine;

public class SatelliteNode : SectoredMonoBehaviour
{
	[SerializeField]
	private DamageEffect _damageEffect;
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[SerializeField]
	private Light _lanternLight;
	[SerializeField]
	private Color _lightRepairedColor;
	[SerializeField]
	private MeshRenderer _lanternEmissiveRenderer;
	[SerializeField]
	private int _lanternMaterialIndex;
	[SerializeField]
	private Material _lanternRepairedMaterial;
	[SerializeField]
	private float _repairTime;
}
