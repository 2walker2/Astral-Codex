using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
	[SerializeField]
	private GameObject _projectilePrefab;
	[SerializeField]
	private float _minSpeed;
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _angularSpeed;
	[SerializeField]
	private float _launcherRadius;
	[SerializeField]
	private float _launchConeAngle;
	[SerializeField]
	private bool _useLaunchTimer;
	[SerializeField]
	private float _minLaunchDelay;
	[SerializeField]
	private float _maxLaunchDelay;
}
