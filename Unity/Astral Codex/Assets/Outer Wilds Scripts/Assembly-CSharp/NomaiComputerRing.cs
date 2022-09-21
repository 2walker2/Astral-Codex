using UnityEngine;

public class NomaiComputerRing : MonoBehaviour
{
	[SerializeField]
	private float _radius;
	[SerializeField]
	private DampedSpring _translationSpring;
	[SerializeField]
	private DampedSpring _rotationSpring;
	[SerializeField]
	private float _idleSpinMinDegrees;
	[SerializeField]
	private float _idleSpinMaxDegrees;
	[SerializeField]
	private float _activeSpinSpeed;
	[SerializeField]
	private float _colorFadeTime;
}
