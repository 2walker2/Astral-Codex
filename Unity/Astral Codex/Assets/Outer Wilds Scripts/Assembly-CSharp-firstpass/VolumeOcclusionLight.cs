using UnityEngine;

public class VolumeOcclusionLight : MonoBehaviour
{
	[SerializeField]
	private Vector2 _startSize;
	[SerializeField]
	private Vector2 _endSize;
	[SerializeField]
	private float _range;
	[SerializeField]
	private float _intensity;
	[SerializeField]
	private Texture2D _cookie;
	[SerializeField]
	private bool _distanceBlur;
}
