using UnityEngine;

public class SlideProjector : SectoredMonoBehaviour
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private Transform _lockOnTransform;
	[SerializeField]
	private SlideProjectorSocket _socket;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private OWLightController _gearLightController;
	[SerializeField]
	private OWLight2 _light;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRendererFadeController _lightShaftController;
	[SerializeField]
	protected OWLightController _houseLightController;
	[SerializeField]
	private OWLightController _bounceLightController;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Texture _lightSensorMask;
	[SerializeField]
	private OWTriggerVolume _slideTextureStreamingTrigger;
	[SerializeField]
	private GearInterfaceEffects _gearInterface;
}
