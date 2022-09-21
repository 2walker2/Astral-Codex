using UnityEngine;

public class AudioVolume : PriorityVolume
{
	[SerializeField]
	protected float _fadeSeconds;
	[SerializeField]
	protected bool _noFadeFromBeginning;
	[SerializeField]
	protected bool _randomizePlayhead;
	[SerializeField]
	protected bool _pauseOnFadeOut;
	[SerializeField]
	protected OWTriggerVolume _triggerVolumeOverride;
}
