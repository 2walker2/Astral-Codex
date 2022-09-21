public class StreamingMeshAssetBundle : StreamingAssetBundle
{
	public StreamingMeshAssetBundle(string assetBundleName, string[] meshNamesByID, int[] meshVertexCounts) : base(default(string))
	{
	}

	public StreamingCollisionMeshBakeManager bakeManager;
	public bool doNotUseThreadedBake;
}
