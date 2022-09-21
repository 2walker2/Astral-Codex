using UnityEngine;

public class MemoryUplinkTrigger : MonoBehaviour
{
	[SerializeField]
	private Transform _lockOnTransform;
	[SerializeField]
	private Vector3 _lockOnOffset;
	[SerializeField]
	private TransformAnimator _statueTransformAnimator;
	[SerializeField]
	private OWRenderer _eyeRenderer;
	[SerializeField]
	private OWLight _planetAmbientLight;
	[SerializeField]
	private OWLight _observatoryAmbientLight;
	[SerializeField]
	private TransformAnimator[] _upperLidAnimators;
	[SerializeField]
	private TransformAnimator[] _lowerLidAnimators;
	[SerializeField]
	private OWAudioSource _statueAudioSource;
}
