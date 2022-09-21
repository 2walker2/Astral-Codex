using UnityEngine;

public class ThrustAndAttitudeIndicator : MonoBehaviour
{
	[SerializeField]
	private Transform _thrusterArrowRoot;
	[SerializeField]
	private MeshRenderer _rendererForward;
	[SerializeField]
	private MeshRenderer _rendererBack;
	[SerializeField]
	private MeshRenderer _rendererRight;
	[SerializeField]
	private MeshRenderer _rendererLeft;
	[SerializeField]
	private MeshRenderer _rendererUp;
	[SerializeField]
	private MeshRenderer _rendererDown;
	[SerializeField]
	private MeshRenderer _boostArrows;
	[SerializeField]
	private Light[] _lightsForward;
	[SerializeField]
	private Light[] _lightsBack;
	[SerializeField]
	private Light[] _lightsRight;
	[SerializeField]
	private Light[] _lightsLeft;
	[SerializeField]
	private Light[] _lightsUp;
	[SerializeField]
	private Light[] _lightsDown;
	[SerializeField]
	private Transform _yawCircle;
	[SerializeField]
	private Transform _pitchCircle;
	[SerializeField]
	private Transform _rollCircle;
	[SerializeField]
	private bool _reticuleMode;
	[SerializeField]
	private bool _shipIndicatorMode;
}
