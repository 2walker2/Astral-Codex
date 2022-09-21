using UnityEngine;

public class StreamingMeshHandle : MonoBehaviour
{
	[SerializeField]
	public string assetBundle;
	[SerializeField]
	public int meshIndex;
	[SerializeField]
	public Mesh proxyMesh;
}
