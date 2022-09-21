using UnityEngine;

public class DirectionalForceVolume : ForceVolume
{
	[SerializeField]
	private Vector3 _fieldDirection;
	[SerializeField]
	private float _fieldMagnitude;
	[SerializeField]
	private bool _affectsAlignment;
	[SerializeField]
	private bool _offsetCentripetalForce;
	[SerializeField]
	private bool _playGravityCrystalAudio;
}
