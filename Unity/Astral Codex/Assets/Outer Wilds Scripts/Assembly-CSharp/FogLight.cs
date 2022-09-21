using UnityEngine;

public class FogLight : MonoBehaviour
{
	[SerializeField]
	private Texture2D _lightIcon;
	[SerializeField]
	private Color _tint;
	[SerializeField]
	private float _occlusionRange;
	[SerializeField]
	private float _minVisibleDistance;
	[SerializeField]
	private float _maxVisibleDistance;
	[SerializeField]
	private float _maxAlpha;
}
