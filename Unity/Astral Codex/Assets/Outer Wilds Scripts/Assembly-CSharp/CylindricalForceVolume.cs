using UnityEngine;

public class CylindricalForceVolume : ForceVolume
{
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private Vector3 _localAxis;
	[SerializeField]
	private bool _playGravityCrystalAudio;
}
