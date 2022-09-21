using UnityEngine;

public class MakeChildrenFragments : MonoBehaviour
{
	[SerializeField]
	private float _integrity;
	[SerializeField]
	private float _propagateToChildFraction;
	[SerializeField]
	private Material _fractureMaterial;
	[SerializeField]
	private float _fractionDetachable;
	[SerializeField]
	private float _drag;
	[SerializeField]
	private DetachableFragment.ForceMask _forceDetection;
	[SerializeField]
	private bool _addCullGroup;
	[SerializeField]
	private Sector _cullGroupSector;
	[SerializeField]
	private bool _addCollisionGroup;
	[SerializeField]
	private Sector _collisionGroupSector;
	[SerializeField]
	private bool _addLightGroup;
	[SerializeField]
	private Sector _lightGroupSector;
}
