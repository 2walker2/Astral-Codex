using UnityEngine;
using Tessellation;

public class TessellatedRenderer : MonoBehaviour
{
	[SerializeField]
	protected MeshGroup _tessellationMeshGroup;
	[SerializeField]
	protected Material[] _materials;
	[SerializeField]
	protected Patch.CullingMode _cullingMode;
	[SerializeField]
	protected int _maxLOD;
	[SerializeField]
	protected int _LODBias;
	[SerializeField]
	protected float _LODRadius;
}
