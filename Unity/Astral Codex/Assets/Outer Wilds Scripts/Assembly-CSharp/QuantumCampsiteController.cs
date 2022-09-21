using UnityEngine;

public class QuantumCampsiteController : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _trigger;
	[SerializeField]
	private Campfire _campfire;
	[SerializeField]
	private GameObject _treeVolume;
	[SerializeField]
	private MultiStateQuantumObject _quantumCampfire;
	[SerializeField]
	private GameObject _campsiteRoot;
	[SerializeField]
	private EndlessTriggerVolume _endlessCampsiteVolume;
	[SerializeField]
	private MultiStateQuantumObject _quantumEsker;
	[SerializeField]
	private CharacterDialogueTree _eskerDialogue;
	[SerializeField]
	private CharacterDialogueTree _riebeckDialogue;
	[SerializeField]
	private GameObject _deepForestRoot;
	[SerializeField]
	private TravelerEyeController[] _travelerControllers;
	[SerializeField]
	private GameObject[] _instrumentZones;
	[SerializeField]
	private Transform[] _travelerRoots;
	[SerializeField]
	private Transform[] _altTravelerSockets;
}
