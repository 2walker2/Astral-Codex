using System;
using UnityEngine;

public struct RelativeLocationData
{
	public RelativeLocationData(OWRigidbody body, Transform relativeTransform) : this()
	{
	}

	public Vector3 localPosition;
	public Quaternion localRotation;
	public Vector3 localRelativeVelocity;
}
