using UnityEngine;

public class TractorBeamController : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _deactivateOnAwake;
	[SerializeField]
	private OWAudioSource _oneShotAudioSrc;
	[SerializeField]
	private Transform _baseTransform;
}
