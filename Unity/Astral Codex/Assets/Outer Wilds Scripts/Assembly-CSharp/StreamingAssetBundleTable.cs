using System;
using UnityEngine;

[Serializable]
public struct StreamingAssetBundleTable
{
	[Serializable]
	public struct Entry
	{
		[SerializeField]
		public string assetBundleName;
		[SerializeField]
		public StreamingAssetBundleTable.BundleType assetBundleType;
		[SerializeField]
		public string[] meshNamesByID;
		[SerializeField]
		public int[] meshVertexCounts;
		[SerializeField]
		public string textureLookupName;
	}

	public enum BundleType
	{
		Generic = 0,
		Mesh = 1,
		Texture = 2,
	}

	public StreamingAssetBundleTable(StreamingAssetBundleTable.Entry[] assetBundles) : this()
	{
	}

	[SerializeField]
	public Entry[] assetBundles;
}
