using UnityEngine;

public class VectionFieldEmitter : MonoBehaviour
{
	public enum EmitDirection
	{
		Random = 0,
		Directional = 1,
		Radial = 2,
		Gravity = 3,
	}

	[SerializeField]
	private Transform _emitterTransform;
	[SerializeField]
	private float _fieldRadius;
	[SerializeField]
	private int _particleCount;
	[SerializeField]
	private bool _emitOnLeadingEdge;
	[SerializeField]
	private EmitDirection _emitDirection;
	[SerializeField]
	private Vector3 _directionalDir;
	[SerializeField]
	private bool _reverseDir;
	[SerializeField]
	private ForceVolume[] _affectingForces;
	[SerializeField]
	private float _forceMultiplier;
	[SerializeField]
	private bool _applyForcePerParticle;
}
