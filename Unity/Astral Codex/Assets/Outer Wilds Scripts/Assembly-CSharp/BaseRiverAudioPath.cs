using UnityEngine;
using System;

public class BaseRiverAudioPath : MonoBehaviour
{
	[Serializable]
	protected struct VertexPair
	{
		public Vector3 v0;
		public Vector3 v1;
	}

	[Serializable]
	public struct Triangle
	{
		public Triangle(BaseRiverAudioPath.Triangle t) : this()
		{
		}

		public Vector3 v0;
		public Vector3 v1;
		public Vector3 v2;
		public Vector3 centroid;
		public Vector3 normal;
		public float cachedDegree;
		public byte allowedEdgeFlags;
		public short[] adjacency;
	}

	[SerializeField]
	protected Transform[] _includedMeshRoots;
	[SerializeField]
	protected Transform[] _meshExceptions;
	[SerializeField]
	protected int sampledTrianglesCount;
	[SerializeField]
	protected float minY;
	[SerializeField]
	protected float maxY;
	[SerializeField]
	protected bool _loop;
	[SerializeField]
	protected Mesh _meshToImport;
	[SerializeField]
	protected VertexPair[] voronoiLines;
	[SerializeField]
	protected Triangle[] _baseFloodTriangles;
	[SerializeField]
	protected float[] _cachedTriangleSections;
	[SerializeField]
	protected bool _importedMesh;
	public bool showVoronoi;
	public bool showPostFlood;
	[SerializeField]
	private bool _showCentroidLabels;
	[SerializeField]
	private bool _showAdjacency;
}
