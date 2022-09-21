using UnityEngine;

public class HeightmapAmbientLight : SectoredMonoBehaviour
{
	[SerializeField]
	private Texture2D _heightmap;
	[SerializeField]
	private Vector3 _size;
	[SerializeField]
	private float _falloff;
	[SerializeField]
	private float _intensity;
	[SerializeField]
	private Color _color;
	[SerializeField]
	private Texture2D _gradient;
}
