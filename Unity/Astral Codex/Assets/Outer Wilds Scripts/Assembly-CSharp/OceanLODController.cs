using UnityEngine;

public class OceanLODController : SectoredMonoBehaviour
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private Texture2D _ambientLightLookup;
	[SerializeField]
	private int _maxLOD_High;
	[SerializeField]
	private int _LODBias_High;
	[SerializeField]
	private int _maxLOD_Medium;
	[SerializeField]
	private int _LODBias_Medium;
	[SerializeField]
	private int _maxLOD_Low;
	[SerializeField]
	private int _LODBias_Low;
}
