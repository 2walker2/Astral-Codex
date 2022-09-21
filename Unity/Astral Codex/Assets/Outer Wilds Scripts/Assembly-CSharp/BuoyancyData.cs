using System;
using UnityEngine;

[Serializable]
public class BuoyancyData
{
	public float density;
	public float boundingRadius;
	public AnimationCurve submergeCurve;
	public AnimationCurve dragCurve;
	public bool checkAgainstWaves;
}
