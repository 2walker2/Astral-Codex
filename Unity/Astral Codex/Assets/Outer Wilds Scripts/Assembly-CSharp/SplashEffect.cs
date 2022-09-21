using System;
using UnityEngine;

[Serializable]
public class SplashEffect
{
	public enum TriggerEvent
	{
		OnEntry = 1,
		OnExit = 2,
		OnEntryOrExit = 3,
	}

	public FluidVolume.Type fluidType;
	public float minImpactSpeed;
	public TriggerEvent triggerEvent;
	public GameObject splashPrefab;
	public bool ignoreSphereAligment;
}
