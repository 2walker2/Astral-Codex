using System;
using UnityEngine;

[Serializable]
public class RotationObject
{
	public enum RotationType
	{
		OPEN_CLOSE = 0,
		INTERVAL = 1,
	}

	public RotationType rotationType;
	public GameObject objectToRotate;
	public Vector3 openRotation;
	public Vector3 closedRotation;
	public Vector3 intervalRotation;
	public float rotationStartTimeOffset;
	public AnimationCurve rotationCurve;
}
