using UnityEngine;

public class CloakFieldController : MonoBehaviour
{
	[SerializeField]
	private OWRenderer _cloakSphereRenderer;
	[SerializeField]
	private Sector _exclusionSector;
	[SerializeField]
	private ReferenceFrameVolume _referenceFrameVolume;
	[SerializeField]
	private SphereShape _cloakSphereShape;
	[SerializeField]
	private OWTriggerVolume _cloakSphereVolume;
	[SerializeField]
	private float _nearCloakRadius;
	[SerializeField]
	private float _farCloakRadius;
	[SerializeField]
	private float _innerCloakRadius;
	[SerializeField]
	private float _cloakScaleDist;
	[SerializeField]
	private float _entryFadeOutLength;
	[SerializeField]
	private float _entryFadeInLength;
	[SerializeField]
	private float _exitFadeOutLength;
	[SerializeField]
	private float _exitFadeInLength;
	[SerializeField]
	private OWRenderer[] _ringworldFadeRenderers;
	[SerializeField]
	private OWAudioSource _musicAudioSource;
}
