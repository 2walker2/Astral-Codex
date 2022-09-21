using UnityEngine;

public class TimeLoopCoreController : MonoBehaviour
{
	[SerializeField]
	private AudioVolume _musicVolume;
	[SerializeField]
	private OWAudioSource _coreCasingAudio;
	[SerializeField]
	private NomaiInterfaceSlot _openSlot;
	[SerializeField]
	private WarpCoreSocket _warpCoreSocket;
	[SerializeField]
	private TransformAnimator[] _panelAnimators;
	[SerializeField]
	private SingularityController _blackHoleEffect;
	[SerializeField]
	private EffectVolume _attractVolume;
	[SerializeField]
	private TimeLoopBlackHoleVolume _timeLoopBlackHoleVolume;
	[SerializeField]
	private TimeLoopLightController _timeLoopLightController;
	[SerializeField]
	private GameObject[] _dataStreamObjects;
	[SerializeField]
	private OWAudioSource _dataStreamAudio;
	[SerializeField]
	private Renderer _chamberDestructionEffect;
	[SerializeField]
	private TravelerController _duplicatePlayer;
	[SerializeField]
	private SurveyorProbe _duplicateProbe;
	[SerializeField]
	private Transform _duplicateProbeSocket;
}
