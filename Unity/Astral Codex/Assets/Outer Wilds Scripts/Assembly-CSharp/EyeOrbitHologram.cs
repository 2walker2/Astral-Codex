using UnityEngine;

public class EyeOrbitHologram : Hologram
{
	[SerializeField]
	private Transform _solarSystemRoot;
	[SerializeField]
	private HologramOrbit[] _orbits;
	[SerializeField]
	private GameObject _eyeOrbitPrefab;
	[SerializeField]
	private bool _rotatingEyeMode;
}
