using UnityEngine;

public class NomaiGateway : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _startOpen;
	[SerializeField]
	private bool _openFromBothEnds;
	[SerializeField]
	private float _slabInterval;
	[SerializeField]
	private NomaiInterfaceSlot _openSlot;
	[SerializeField]
	private NomaiInterfaceSlot _closeSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private NomaiGatewaySlab[] _slabs;
	[SerializeField]
	private OWAudioSource _audioSource;
}
