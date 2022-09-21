using UnityEngine;

public class NomaiAirlock : NomaiMultiPartDoor
{
	[SerializeField]
	private OWTriggerVolume _oxygenVolume;
	[SerializeField]
	private GameObject _underwaterStencil;
	[SerializeField]
	private bool _startOxygenated;
	[SerializeField]
	private OWAudioSource _airSFXAudioSource;
	[SerializeField]
	private float _oxygenationPoint;
	[SerializeField]
	private AudioType _airPourInSound;
	[SerializeField]
	private AudioType _airPourOutSound;
}
