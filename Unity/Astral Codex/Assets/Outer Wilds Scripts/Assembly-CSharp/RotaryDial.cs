using UnityEngine;

public class RotaryDial : MonoBehaviour
{
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private int _nbSymbols;
	[SerializeField]
	private int _symbolSelected;
	[SerializeField]
	private float _timeToStartRotating;
	[SerializeField]
	private float _timePerRotation;
	[SerializeField]
	private float _rotationSpeed;
	[SerializeField]
	private float _anglePrecision;
	[SerializeField]
	private bool _snapToClosest;
	[SerializeField]
	private Material _glowMaterial;
	[SerializeField]
	private MeshRenderer _renderer;
}
