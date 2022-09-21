using UnityEngine;

public class GhostRandomWalk : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private Transform _normalRef;
	[SerializeField]
	private Transform _eyeLevel;
	[SerializeField]
	private Vector2 _changeDirIntervalRange;
	[SerializeField]
	private float _speed;
	[SerializeField]
	private float _turnSpeed;
	[SerializeField]
	private Collider _collider;
}
