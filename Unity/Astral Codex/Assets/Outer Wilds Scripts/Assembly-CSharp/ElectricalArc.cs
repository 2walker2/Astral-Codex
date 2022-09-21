using UnityEngine;

public class ElectricalArc : MonoBehaviour
{
	public enum Mode
	{
		Looping = 0,
		Jumping = 1,
		OneShot = 2,
	}

	public enum Dimension
	{
		_1D = 1,
		_2D = 2,
		_3D = 3,
	}

	[SerializeField]
	private Transform _startTransform;
	[SerializeField]
	private Vector3 _startLocalPosition;
	[SerializeField]
	private Transform _endTransform;
	[SerializeField]
	private Vector3 _endLocalPosition;
	[SerializeField]
	private Material _material;
	[SerializeField]
	private int _resolution;
	[SerializeField]
	private float _width;
	[SerializeField]
	private Mode _mode;
	[SerializeField]
	private float _frequency;
	[SerializeField]
	private float _intensity;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private float _scrollSpeed;
	[SerializeField]
	private float _jumpTime;
	[SerializeField]
	private Vector3 _jumpDirection;
	[SerializeField]
	private Dimension _dimension;
	[SerializeField]
	private Vector3 _dimensionScale;
	[SerializeField]
	private int _octaves;
}
