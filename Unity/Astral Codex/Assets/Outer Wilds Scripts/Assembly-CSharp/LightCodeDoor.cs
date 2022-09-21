using UnityEngine;

public class LightCodeDoor : MonoBehaviour
{
	[SerializeField]
	private LightCodeInterpreter _lightCodeInterpreter;
	[SerializeField]
	private Transform _target;
	[SerializeField]
	private bool _startsOpen;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private float _speed;
}
