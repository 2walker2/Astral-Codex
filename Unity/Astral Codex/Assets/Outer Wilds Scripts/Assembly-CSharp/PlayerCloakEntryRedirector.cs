using UnityEngine;

public class PlayerCloakEntryRedirector : MonoBehaviour
{
	[SerializeField]
	private CloakFieldController _cloakField;
	[SerializeField]
	private Transform _velocityTarget;
	[SerializeField]
	private float _targetRepositionAngle;
	[SerializeField]
	private float _maxEntryAngle;
}
