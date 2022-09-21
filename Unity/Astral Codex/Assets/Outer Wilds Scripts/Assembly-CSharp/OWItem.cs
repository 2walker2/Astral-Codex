using UnityEngine;

public class OWItem : SectoredMonoBehaviour
{
	[SerializeField]
	protected float _interactRange;
	[SerializeField]
	private Vector3 _localDropOffset;
	[SerializeField]
	private Vector3 _localDropNormal;
	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	protected OWCollider[] _colliders;
	[SerializeField]
	protected OWRenderer[] _renderers;
	[SerializeField]
	protected ParticleSystem[] _particleSystems;
	[SerializeField]
	protected OWLight2[] _lights;
}
