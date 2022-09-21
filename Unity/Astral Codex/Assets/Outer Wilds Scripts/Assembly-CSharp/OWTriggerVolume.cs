using UnityEngine;

public class OWTriggerVolume : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _initialOccupants;
	[SerializeField]
	private EntrywayTrigger[] _sharedEntryways;
	[SerializeField]
	private bool _ignoreDuplicateOccupantWarning;
}
