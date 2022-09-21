using UnityEngine;

public class DecalProjector : MonoBehaviour
{
	public enum UVSplittingDimensions
	{
		TWO_BY_TWO = 0,
		FOUR_BY_FOUR = 1,
	}

	[SerializeField]
	public bool _drawMeshTriangles;
	[SerializeField]
	public bool _drawTrimmedTriangles;
	[SerializeField]
	public bool _staggerTrimmedTriangles;
	[SerializeField]
	public bool _drawProjectorCube;
	[SerializeField]
	public bool _drawMeshTangents;
	[SerializeField]
	protected Shader _shader;
	[SerializeField]
	private Texture2D _texture;
	[SerializeField]
	private Vector2 _textureUVMin;
	[SerializeField]
	private Vector2 _textureUVMax;
	[SerializeField]
	public UVSplittingDimensions _tilingDimensions;
	[SerializeField]
	protected GameObject _projectedMesh;
	[SerializeField]
	protected string _projectionAssetGuid;
}
