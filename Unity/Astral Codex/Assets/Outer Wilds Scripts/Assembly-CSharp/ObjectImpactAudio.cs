using UnityEngine;

public class ObjectImpactAudio : MonoBehaviour
{
	[SerializeField]
	private AudioType _clipType;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private float _minSpeed;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _minPitch;
	[SerializeField]
	private float _maxPitch;
	[SerializeField]
	private float _minCollidingMass;
}
