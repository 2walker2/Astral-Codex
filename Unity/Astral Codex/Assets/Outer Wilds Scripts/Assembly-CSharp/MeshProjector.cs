using UnityEngine;

public class MeshProjector : MonoBehaviour
{
	public enum Mode
	{
		PhysicalLayer = 0,
		SingleMesh = 1,
		Hierarchy = 2,
	}

	[SerializeField]
	private Mesh _mesh;
	[SerializeField]
	private Material _material;
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private GameObject[] _targets;
	[SerializeField]
	private Vector2 _size;
	[SerializeField]
	private float _distance;
	[SerializeField]
	private Vector2 _uvMin;
	[SerializeField]
	private Vector2 _uvMax;
	[SerializeField]
	private Color _color;
	[SerializeField]
	private Vector2 _angleFade;
	[SerializeField]
	private bool _inheritVertexColors;
	[SerializeField]
	private bool _inheritUV1;
	[SerializeField]
	private bool _inheritUV2;
	[SerializeField]
	private bool _inheritUV3;
	[SerializeField]
	private bool _inheritUV4;
	[SerializeField]
	private bool _offsetFromSurface;
	[SerializeField]
	private float _surfaceOffsetDistance;
}
