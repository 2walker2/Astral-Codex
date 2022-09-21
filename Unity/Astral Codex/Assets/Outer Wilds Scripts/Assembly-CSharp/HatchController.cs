using UnityEngine;

public class HatchController : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private GameObject _hatchObject;
	[SerializeField]
	private Transform _hatch;
	[SerializeField]
	private float _hatchOpenTime;
	[SerializeField]
	private Vector3 _hatchClosedRotation;
	[SerializeField]
	private Vector3 _hatchOpenedRotation;
}
