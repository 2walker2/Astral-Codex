using UnityEngine;

public class ShipLogFactObserveTrigger : MonoBehaviour
{
	[SerializeField]
	private string _factID;
	[SerializeField]
	private string[] _factIDs;
	[SerializeField]
	private float _maxViewDistance;
	[SerializeField]
	private float _maxViewAngle;
	[SerializeField]
	private bool _disableColliderOnRevealFact;
}
