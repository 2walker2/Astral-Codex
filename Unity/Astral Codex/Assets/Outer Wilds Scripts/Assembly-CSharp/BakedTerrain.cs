using UnityEngine;
using TerrainBaker;

public class BakedTerrain : MonoBehaviour
{
	[SerializeField]
	private GameObject _terrainMeshGroup;
	[SerializeField]
	private GameObject _subtractiveMeshGroup;
	[SerializeField]
	private GameObject _staticMeshGroup;
	[SerializeField]
	private bool _bakeColliders;
	[SerializeField]
	private Settings _settings;
	[SerializeField]
	private string _exportPath;
}
