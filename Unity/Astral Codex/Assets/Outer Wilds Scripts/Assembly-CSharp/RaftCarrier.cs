using UnityEngine;

public class RaftCarrier : MonoBehaviour
{
	[SerializeField]
	protected OWTriggerVolume _trigger;
	[SerializeField]
	protected Transform _craneChains;
	[SerializeField]
	protected Transform _craneHookRoot;
	[SerializeField]
	protected float _craneHookChainOffset;
	[SerializeField]
	protected float _hookStartLocalY;
	[SerializeField]
	protected float _raftAlignSpeed;
	[SerializeField]
	protected float _liftingDelay;
	[SerializeField]
	protected Vector2 _chainTilingModifier;
	[SerializeField]
	protected OWAudioSource _oneShotAudio;
	[SerializeField]
	protected OWAudioSource _loopingAudio;
	[SerializeField]
	protected Animator _hooksAnimator;
}
