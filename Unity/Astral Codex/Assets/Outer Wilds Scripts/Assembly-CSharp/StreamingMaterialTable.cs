using System;
using UnityEngine;

[Serializable]
public class StreamingMaterialTable : ScriptableObject
{
	[Serializable]
	private struct PropertyLookup
	{
		public string propertyName;
		public int propertyID;
		public int textureIndex;
		public Texture lodTexture;
	}

	[Serializable]
	private struct MaterialPropertyLookup
	{
		public Material material;
		public StreamingMaterialTable.PropertyLookup[] propertyLookups;
	}

	public enum Type
	{
		General = 0,
		Terrain = 1,
		Detail = 2,
		Character = 3,
	}

	[SerializeField]
	public string assetBundle;
	[SerializeField]
	public Type type;
	[SerializeField]
	private MaterialPropertyLookup[] _materialPropertyLookups;
}
