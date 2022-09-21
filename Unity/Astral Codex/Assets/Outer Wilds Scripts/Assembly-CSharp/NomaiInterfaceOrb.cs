using UnityEngine;

public class NomaiInterfaceOrb : SectoredMonoBehaviour
{
	[SerializeField]
	private Collider _interactibleCollider;
	[SerializeField]
	private SphereCollider _physicalCollider;
	[SerializeField]
	private Renderer _glowRenderer;
	[SerializeField]
	private Renderer _extraGlowRenderer;
	[SerializeField]
	private Light _glowLight;
	[SerializeField]
	private Light _extraGlowLight;
	[SerializeField]
	private Color _draggingGlowColor;
	[SerializeField]
	private float _startDragDist;
	[SerializeField]
	private float _cancelDragDist;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private GameObject _slotRoot;
	[SerializeField]
	private bool _freezeLocalZAxis;
	[SerializeField]
	private bool _freezeLocalRotation;
	[SerializeField]
	private bool _isQuantum;
	[SerializeField]
	private bool _isOnFragment;
	[SerializeField]
	private bool _applyForcesWhileMoving;
	[SerializeField]
	private OWRail[] _safetyRails;
	[SerializeField]
	private float _maxRailDistance;
}
