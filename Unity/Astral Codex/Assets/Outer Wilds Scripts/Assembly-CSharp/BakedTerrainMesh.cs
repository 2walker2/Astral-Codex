using System;
using UnityEngine;

[Serializable]
public class BakedTerrainMesh : ScriptableObject
{
	public Mesh _mesh;
	public Mesh colliderMesh;
}
