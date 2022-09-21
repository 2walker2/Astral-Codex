using UnityEngine;

public class AudioSignal : SectoredMonoBehaviour
{
	[SerializeField]
	private SignalFrequency _frequency;
	[SerializeField]
	private SignalName _name;
	[SerializeField]
	private float _sourceRadius;
	[SerializeField]
	private float _identificationDistance;
	[SerializeField]
	private float _waveformScalar;
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private bool _onlyAudibleToScope;
	[SerializeField]
	private bool _preventIdentification;
	[SerializeField]
	private OuterFogWarpVolume _outerFogWarpVolume;
	[SerializeField]
	private string _revealFactID;
	[SerializeField]
	private bool _debug;
}
