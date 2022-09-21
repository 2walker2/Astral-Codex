using UnityEngine;

public class FragmentCollisionProxy : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _boundsRadius;
	[SerializeField]
	private Transform _testRaycaster;
	[SerializeField]
	private float _testRaycastLength;
	[SerializeField]
	private Mesh _proxyColliderMesh;
	[SerializeField]
	private FragmentIntegrity[] _fragmentArray;
	[SerializeField]
	private int[] _submeshIndices;
}
