using UnityEngine;

public class NomaiVesselComputer : NomaiText
{
	[SerializeField]
	private bool _startActivated;
	[SerializeField]
	private Transform _pillarObject;
	[SerializeField]
	private float _pillarStowedHeight;
	[SerializeField]
	private float _pillarExtendedHeight;
	[SerializeField]
	private float _pillarMoveTime;
	[SerializeField]
	private OWLight2 _topLight;
	[SerializeField]
	private OWEmissiveRenderer _topLightRenderer;
	[SerializeField]
	private float _lightFadeTime;
	[SerializeField]
	private NomaiVesselComputerRing[] _computerRings;
	[SerializeField]
	private float _ringDelay;
	[SerializeField]
	private OWAudioSource _audioSource;
}
