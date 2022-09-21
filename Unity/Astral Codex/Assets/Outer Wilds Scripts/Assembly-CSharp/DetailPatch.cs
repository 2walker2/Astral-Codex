using UnityEngine;

public class DetailPatch : MonoBehaviour
{
	public enum Mode
	{
		PhysicalLayer = 0,
		SingleMesh = 1,
		Hierarchy = 2,
	}

	public enum Shape
	{
		Box = 0,
		Cylinder = 1,
	}

	[SerializeField]
	private DetailPalette _palette;
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private GameObject[] _targets;
	[SerializeField]
	private bool _blockable;
	[SerializeField]
	private Shape _shape;
	[SerializeField]
	private Vector2 _size;
	[SerializeField]
	private float _distance;
	[SerializeField]
	private int _seed;
	[SerializeField]
	private int _count;
	[SerializeField]
	private bool _separation;
	[SerializeField]
	private AnimationCurve _distribution;
	[SerializeField]
	private DetailInstance[] _instances;
	[SerializeField]
	private Mesh _mesh;
	[SerializeField]
	private Material[] _materials;
}
