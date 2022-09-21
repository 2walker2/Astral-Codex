using UnityEngine;

public class MindSlideProjector : MonoBehaviour
{
	[SerializeField]
	private MindSlideCollection _mindSlideCollection;
	[SerializeField]
	private AnimationCurve _closingCurve;
	[SerializeField]
	private float _closingDuration;
	[SerializeField]
	private AnimationCurve _openingCurve;
	[SerializeField]
	private float _openingDuration;
	[SerializeField]
	private float _startSlideFadeCloseTimeOffset;
	[SerializeField]
	private float _slideFadeDuration;
	[SerializeField]
	private float _defaultSlideDuration;
	[SerializeField]
	private SlideCollectionContainer _slideCollectionItem;
}
