using UnityEngine;

public class ProxyBrittleHollow : ProxyPlanet
{
	[SerializeField]
	private MeshRenderer[] _planetRenderers;
	[SerializeField]
	private MeshRenderer _blackHoleRenderer;
	[SerializeField]
	private ProxyOrbiter _moon;
	[SerializeField]
	private ProxyBrittleHollowFragment[] _fragments;
	[SerializeField]
	private bool _collectFragments;
	[SerializeField]
	private bool _collectStaticRenderers;
	[SerializeField]
	private bool _saveFragmentNames;
}
