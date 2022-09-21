using UnityEngine;

public class CharacterAnimController : SectoredMonoBehaviour
{
	[SerializeField]
	private Animator _secondaryAnimator;
	[SerializeField]
	protected CharacterDialogueTree _dialogueTree;
	public OWTriggerVolume playerTrackingZone;
	public DampedSpring3D lookSpring;
	public bool lookOnlyWhenTalking;
	public float headTrackingWeight;
	[SerializeField]
	protected float _blinksPerMinute;
	[SerializeField]
	protected float _blinkDuration;
	[SerializeField]
	protected BlinkBlendshape _blinkStyle;
	[SerializeField]
	protected SkinnedMeshRenderer _skinRenderer;
	[SerializeField]
	protected bool _hasTalkAnimation;
}
