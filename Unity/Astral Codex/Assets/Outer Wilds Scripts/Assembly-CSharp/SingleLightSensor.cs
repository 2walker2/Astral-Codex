using UnityEngine;

public class SingleLightSensor : LightSensor
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private bool _startIlluminated;
	[SerializeField]
	private bool _preserveStateWhileDisabled;
	[SerializeField]
	private bool _detectFlashlight;
	[SerializeField]
	private bool _detectProbe;
	[SerializeField]
	private bool _detectDreamLanterns;
	[SerializeField]
	private bool _detectSimpleLanterns;
	[SerializeField]
	private float _lanternFocusThreshold;
	[SerializeField]
	private bool _checkForOcclusion;
	[SerializeField]
	private float _maxDistance;
	[SerializeField]
	private float _maxSimpleLanternDistance;
	[SerializeField]
	private float _maxSpotHalfAngle;
	[SerializeField]
	private bool _directionalSensor;
	[SerializeField]
	private Vector3 _localDirection;
	[SerializeField]
	private float _detectionAngle;
	[SerializeField]
	private float _sensorRadius;
	[SerializeField]
	private Vector3 _localSensorOffset;
}
