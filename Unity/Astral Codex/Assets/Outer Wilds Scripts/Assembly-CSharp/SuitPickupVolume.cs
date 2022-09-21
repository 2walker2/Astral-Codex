using UnityEngine;

public class SuitPickupVolume : MonoBehaviour
{
	[SerializeField]
	private bool _isTrainingSuit;
	[SerializeField]
	private bool _allowSuitReturn;
	[SerializeField]
	private GameObject _suitGeometry;
	[SerializeField]
	private GameObject[] _toolGeometry;
	[SerializeField]
	private float _toolPickupDelay;
	[SerializeField]
	private Collider _suitCollider;
	[SerializeField]
	private bool _enableSuitOptionsMenu;
}
