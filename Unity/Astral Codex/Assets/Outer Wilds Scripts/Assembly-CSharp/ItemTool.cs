using UnityEngine;

public class ItemTool : PlayerTool
{
	[SerializeField]
	private GameObject _defaultItemSocket;
	[SerializeField]
	private GameObject _scrollSocket;
	[SerializeField]
	private GameObject _sharedStoneSocket;
	[SerializeField]
	private GameObject _warpCoreSocket;
	[SerializeField]
	private GameObject _vesselCoreSocket;
	[SerializeField]
	private GameObject _simpleLanternSocket;
	[SerializeField]
	private GameObject _dreamLanternSocket;
	[SerializeField]
	private GameObject _slideReelSocket;
	[SerializeField]
	private GameObject _visionTorchSocket;
	[SerializeField]
	private Transform _vesselCoreStowTransform;
	[SerializeField]
	private float _dropDistanceInFront;
	[SerializeField]
	private float _maxDroppableSlopeAngle;
}
