using UnityEngine;

public class QuantumSocket : MonoBehaviour
{
	[SerializeField]
	private int _probabilityMultiplier;
	[SerializeField]
	private GameObject _emptySocketObject;
	[SerializeField]
	private GameObject _filledSocketObject;
	[SerializeField]
	private QuantumSocket _linkedSocket;
	[SerializeField]
	private Light[] _lightSources;
	[SerializeField]
	private OWTriggerVolume _occupiedByPlayerVolume;
}
