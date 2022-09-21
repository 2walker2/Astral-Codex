using UnityEngine;

public class MeshBatch : MonoBehaviour
{
	[SerializeField]
	private GameObject _originalGroup;
	[SerializeField]
	private GameObject _cloneGroup;
	[SerializeField]
	private GameObject _batchedGroup;
	[SerializeField]
	private bool _batchMeshRenderers;
	[SerializeField]
	private bool _spatialGrouping;
	[SerializeField]
	private float _groupingRadius;
	[SerializeField]
	private bool _batchMeshColliders;
	[SerializeField]
	private PhysicMaterial _physicMaterial;
}
