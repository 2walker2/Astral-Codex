using UnityEngine;

public class OrbitLine : MonoBehaviour
{
	[SerializeField]
	protected AstroObject _astroObject;
	[SerializeField]
	protected int _numVerts;
	[SerializeField]
	protected float _arcDegrees;
	[SerializeField]
	protected Color _color;
	[SerializeField]
	protected float _lineWidth;
	[SerializeField]
	protected float _maxLineWidth;
	[SerializeField]
	protected bool _fade;
	[SerializeField]
	protected float _fadeStartDist;
	[SerializeField]
	protected float _fadeEndDist;
}
