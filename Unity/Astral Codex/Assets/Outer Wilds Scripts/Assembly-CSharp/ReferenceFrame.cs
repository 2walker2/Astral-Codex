using System;
using UnityEngine;

[Serializable]
public class ReferenceFrame
{
	public ReferenceFrame(OWRigidbody attachedOWRigidbody)
	{
	}

	[SerializeField]
	private float _minSuitTargetDistance;
	[SerializeField]
	private float _maxTargetDistance;
	[SerializeField]
	private float _autopilotArrivalDistance;
	[SerializeField]
	private float _autoAlignmentDistance;
	[SerializeField]
	private bool _hideLandingModePrompt;
	[SerializeField]
	private bool _matchAngularVelocity;
	[SerializeField]
	private float _minMatchAngularVelocityDistance;
	[SerializeField]
	private float _maxMatchAngularVelocityDistance;
	[SerializeField]
	private float _bracketsRadius;
}
