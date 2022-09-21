using UnityEngine;

public class AutoSlideProjector : SectoredMonoBehaviour
{
	[SerializeField]
	private float _defaultSlideDuration;
	[SerializeField]
	private float _endPauseDuration;
	[SerializeField]
	private SlideCollectionContainer _slideCollectionItem;
	[SerializeField]
	private OWLight2 _light;
	[SerializeField]
	private OWLight2 _bounceLight;
	[SerializeField]
	private OWRenderer[] _lightShaftRenderers;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
