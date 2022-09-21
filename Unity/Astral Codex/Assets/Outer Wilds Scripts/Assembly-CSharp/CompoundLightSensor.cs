using UnityEngine;

public class CompoundLightSensor : LightSensor
{
	[SerializeField]
	private SingleLightSensor[] _childSensors;
}
