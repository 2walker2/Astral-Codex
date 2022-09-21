using UnityEngine;

public class DamFragmentController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private Transform _snapTarget;
	[SerializeField]
	private float _attachDelay;
	[SerializeField]
	private OWCollider[] _lowResColliders;
	[SerializeField]
	private OWCollider _highResCollider;
	[SerializeField]
	private GameObject _turningOffInFlood;
}
