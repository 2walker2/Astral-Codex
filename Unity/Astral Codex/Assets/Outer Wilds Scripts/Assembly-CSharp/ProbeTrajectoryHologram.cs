using UnityEngine;

public class ProbeTrajectoryHologram : Hologram
{
	[SerializeField]
	private AnimationCurve _launchRateCurve;
	[SerializeField]
	private GameObject _probePathPrefab;
	[SerializeField]
	private Transform _probeLauncherTransform;
	[SerializeField]
	private Transform _solarSystemTransform;
	[SerializeField]
	private Transform _eyeSocket;
	[SerializeField]
	private bool _latestLaunchOnly;
}
