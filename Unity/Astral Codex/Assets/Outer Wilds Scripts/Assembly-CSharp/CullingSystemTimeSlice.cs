using UnityEngine;

public class CullingSystemTimeSlice : MonoBehaviour
{
	[SerializeField]
	private GameObject _CullingRoot;
	[SerializeField]
	private GameObject _CullingCenter;
	[SerializeField]
	private float _InteriorRadius;
	public bool DEBUG;
	public int _FrameSlice;
	[SerializeField]
	private float DOT;
	[SerializeField]
	private MeshRenderer[] _MeshRenderers;
	[SerializeField]
	private Transform[] _Transforms;
	[SerializeField]
	private Vector3[] _RenderCenters;
}
