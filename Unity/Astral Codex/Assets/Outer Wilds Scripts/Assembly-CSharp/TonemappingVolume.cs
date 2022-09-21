using UnityEngine;

public class TonemappingVolume : MonoBehaviour
{
	[SerializeField]
	private int _priority;
	[SerializeField]
	private float _innerRadius;
	[SerializeField]
	private Texture2D _lut;
}
