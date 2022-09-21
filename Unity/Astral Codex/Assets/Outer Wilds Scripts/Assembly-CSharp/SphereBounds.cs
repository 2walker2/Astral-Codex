using System;
using UnityEngine;

[Serializable]
public struct SphereBounds
{
	public SphereBounds(Bounds aabbBounds) : this()
	{
	}

	public Vector3 center;
	public float radius;
}
