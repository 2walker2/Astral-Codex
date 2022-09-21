using UnityEngine;

public class VisionTorchItem : OWItem
{
	[SerializeField]
	private MindProjectorTrigger _mindProjectorTrigger;
	[SerializeField]
	private MindSlideProjector _mindSlideProjector;
	[SerializeField]
	private Transform _visionBeam;
	[SerializeField]
	private OWRenderer[] _worldModelRenderers;
	[SerializeField]
	private OWRenderer[] _viewModelRenderers;
}
