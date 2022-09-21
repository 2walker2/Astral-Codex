using UnityEngine;

public class EskerAnimController : CharacterAnimController
{
	[SerializeField]
	private OWAudioSource _whistleSource;
	[SerializeField]
	private AnimationCurve _whistleBlendCurve;
	[SerializeField]
	private float _whistleBlendSpeed;
	[SerializeField]
	private TravelerEyeController _travelerEyeController;
}
