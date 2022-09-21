using UnityEngine;

public class TessellatedSphereLOD : MonoBehaviour
{
	[SerializeField]
	public float _highAltitude;
	[SerializeField]
	public Material[] _highAltitudeMaterials;
	[SerializeField]
	public float _lowAltitude;
	[SerializeField]
	public Material[] _lowAltitudeMaterials;
	[SerializeField]
	public int _lowAltitudeMaxLOD;
}
