using UnityEngine;

public class GhostHotelDirector : GhostDirector
{
	[SerializeField]
	private DreamObjectProjector _hotelProjector;
	[SerializeField]
	private OWAudioSource _ghostHowlAudioSource;
	[SerializeField]
	private OWTriggerVolume _depthsExtensionTrigger;
	[SerializeField]
	private GhostBrain[] _hotelDepthsGhosts;
	[SerializeField]
	private GhostEffects _theaterGhostEffects;
	[SerializeField]
	private LightSensor _theaterScreenSensor;
	[SerializeField]
	private AutoSlideProjector _slideProjector;
	[SerializeField]
	private GhostBrain _cafeGhost;
	[SerializeField]
	private GhostNode.NodeLayer _cafeHiddenNodeLayer;
	[SerializeField]
	private GhostNode.NodeLayer _cafeEntranceNodeLayer;
	[SerializeField]
	private GhostNode.NodeLayer _cafeInteriorNodeLayer;
	[SerializeField]
	private OWTriggerVolume _depthsVolume;
	[SerializeField]
	private DreamObjectProjector _bridgeProjector;
}
