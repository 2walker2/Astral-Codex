using UnityEngine;

public class PlaneOffsetMarker : MonoBehaviour
{
	[SerializeField]
	private Transform _trackedObject;
	[SerializeField]
	private Color _lineColor;
	[SerializeField]
	private float _lineWidth;
	[SerializeField]
	private float _maxLineWidth;
	[SerializeField]
	private float _dotFrequency;
	[SerializeField]
	private Color _gridColor;
	[SerializeField]
	private float _gridSize;
	[SerializeField]
	private float _maxGridSize;
	[SerializeField]
	private bool _fade;
	[SerializeField]
	private float _fadeStartDist;
	[SerializeField]
	private float _fadeEndDist;
	[SerializeField]
	private bool _lockOnFade;
	[SerializeField]
	private float _lockOnFadeLength;
}
