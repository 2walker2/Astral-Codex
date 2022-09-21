using UnityEngine;

public class SolanumAnimController : MonoBehaviour
{
	[SerializeField]
	private DampedSpringQuat _lookSpring;
	[SerializeField]
	private GameObject _staffLocked;
	[SerializeField]
	private GameObject _staffUnlocked;
	[SerializeField]
	private OWAudioSource _symbolsAudioSource;
	[SerializeField]
	private OWAudioSource _foleyAudioSource;
}
