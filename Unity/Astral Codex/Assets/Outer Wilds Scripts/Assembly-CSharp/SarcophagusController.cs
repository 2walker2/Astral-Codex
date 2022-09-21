using UnityEngine;

public class SarcophagusController : MonoBehaviour
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private AudioVolume _quietAudioVolume;
	[SerializeField]
	private MindProjectorTrigger _mindProjector;
	[SerializeField]
	private OWTriggerVolume _mindProjectorDisableVolume;
	[SerializeField]
	private DreamObjectProjection[] _sealProjections;
	[SerializeField]
	private Animation _sarcophagusAnimation;
	[SerializeField]
	private bool _debugUnlock;
	[SerializeField]
	private OWTriggerVolume _tunnelSwapVolume;
	[SerializeField]
	private OWTriggerVolume _tunnelEntrywayTrigger;
	[SerializeField]
	private OWRenderer[] _sarcoBackRenderers;
	[SerializeField]
	private OWCollider[] _sarcoBackColliders;
	[SerializeField]
	private OWRenderer[] _tunnelRenderers;
	[SerializeField]
	private OWCollider[] _tunnelColliders;
	[SerializeField]
	private OWRenderer[] _sarcoBackFade;
	[SerializeField]
	private float _sarcoBackFadeStartDist;
	[SerializeField]
	private float _sarcoBackFadeEndDist;
}
