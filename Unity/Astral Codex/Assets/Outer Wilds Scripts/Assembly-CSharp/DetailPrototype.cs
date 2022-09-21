using System;
using UnityEngine;

[Serializable]
public struct DetailPrototype
{
	public enum AlignmentType
	{
		None = 0,
		SurfaceNormal = 1,
		Gravity = 2,
	}

	public Mesh mesh;
	public Material material;
	public float radius;
	public Range rotation;
	public Range scale;
	public Gradient color;
	public AlignmentType alignment;
	public bool hanging;
	public float density;
}
