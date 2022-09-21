using UnityEngine;

public class PrisonerInstrumentToggle : MonoBehaviour
{
	[SerializeField]
	private TravelerEyeController _travelerEyeController;
	[SerializeField]
	private RotateTransform _musicBoxRotator;
	[SerializeField]
	private TransformAnimator _bowTransformAnimator;
	[SerializeField]
	private Transform _idleBowTransform;
	[SerializeField]
	private Transform _playingBowTransform;
}
