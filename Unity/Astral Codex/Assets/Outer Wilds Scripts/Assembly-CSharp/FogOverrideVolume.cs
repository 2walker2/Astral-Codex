using UnityEngine;

public class FogOverrideVolume : SimpleVolume
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _blendDistance;
	[SerializeField]
	private bool _overrideDensity;
	[SerializeField]
	private float _density;
	[SerializeField]
	private bool _overrideColorRampIntensity;
	[SerializeField]
	private float _colorRampIntensity;
	[SerializeField]
	private bool _overrideTint;
	[SerializeField]
	private Color _tint;
}
