using UnityEngine;

public class SimpleLanternItem : OWItem
{
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private CustomCollisionChecker _collisionChecker;
	[SerializeField]
	private bool _startsLit;
	[SerializeField]
	private TransformAnimator _animator;
	[SerializeField]
	private ElectricityEffect _extinguishElectricityEffect;
}
