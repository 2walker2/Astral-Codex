using UnityEngine;

public class ProjectionTest : MonoBehaviour
{
	[SerializeField]
	private float _near;
	[SerializeField]
	private float _right;
	[SerializeField]
	private float _left;
	[SerializeField]
	private float _far;
	[SerializeField]
	private float _top;
	[SerializeField]
	private float _bottom;
	[SerializeField]
	private bool _custom;
	[SerializeField]
	private bool _direct;
	[SerializeField]
	private Matrix4x4 _projectionMatrix;
	[SerializeField]
	private bool _customWorld;
	[SerializeField]
	private bool _directWorld;
	[SerializeField]
	private float _rotAngle;
	[SerializeField]
	private Matrix4x4 _worldCameraMatrix;
}
