using UnityEngine;

public class SunOverrideVolume : SimpleVolume
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private int _priority;
	[SerializeField]
	private float _blendDistance;
	[SerializeField]
	private bool _overrideColor;
	[SerializeField]
	private Color _color;
	[SerializeField]
	private bool _overrideIntensity;
	[SerializeField]
	private float _intensity;
	[SerializeField]
	private bool _overrideAmbientIntensity;
	[SerializeField]
	private float _ambientIntensity;
	[SerializeField]
	private bool _overrideShadowStrength;
	[SerializeField]
	private float _shadowStrength;
}
