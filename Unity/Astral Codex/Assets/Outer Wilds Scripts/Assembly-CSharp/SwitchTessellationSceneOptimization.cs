using UnityEngine;
using Tessellation;

public class SwitchTessellationSceneOptimization : MonoBehaviour
{
	public bool skip;
	[SerializeField]
	protected MeshGroup _tessellationMeshGroup;
	[SerializeField]
	protected int _maxLOD;
	[SerializeField]
	protected int _LODBias;
	[SerializeField]
	protected float _LODRadius;
}
