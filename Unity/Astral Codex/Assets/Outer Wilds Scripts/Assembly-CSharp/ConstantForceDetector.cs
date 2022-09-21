using UnityEngine;

public class ConstantForceDetector : ForceDetector
{
	[SerializeField]
	private ForceVolume[] _detectableFields;
	[SerializeField]
	private ForceDetector _inheritDetector;
	[SerializeField]
	private bool _inheritElement0;
}
