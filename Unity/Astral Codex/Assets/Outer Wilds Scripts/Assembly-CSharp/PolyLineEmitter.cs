using UnityEngine;

public class PolyLineEmitter : MonoBehaviour
{
	[SerializeField]
	private Vector3[] _vertices;
	[SerializeField]
	private bool _looped;
	[SerializeField]
	private int _burstCountMin;
	[SerializeField]
	private int _burstCountMax;
	[SerializeField]
	private float _burstLength;
}
