using System;
using UnityEngine;

[Serializable]
public class SurfaceLookupTable : ScriptableObject
{
	[Serializable]
	public struct SurfaceTypeGroup
	{
		public SurfaceType type;
		public Material[] materials;
	}

	public SurfaceTypeGroup[] surfaceTypeGroups;
}
