using System;
using UnityEngine;

public struct KinematicCollision
{
	public KinematicRigidbody kinematicRigidbody;
	public KinematicCollider thisKinematicCollider;
	public KinematicCollider otherKinematicCollider;
	public Vector3 point;
	public Vector3 normal;
	public Vector3 relativeVelocity;
	public Vector3 impulse;
}
