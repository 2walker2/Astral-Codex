using System;
using UnityEngine;

public class CubeLight : SectoredMonoBehaviour
{
	[Serializable]
	private struct FaceSuperGroup
	{
		public ProxyShadowCasterSuperGroup[] superGroups;
	}

	public bool debugShadowMap;
	public int renderMask;
	[SerializeField]
	private FaceSuperGroup[] _faceSuperGroups;
	[SerializeField]
	private int _neverDrawMask;
	[SerializeField]
	private int _neverDynamicMask;
	[SerializeField]
	private bool _updateFrustums;
	[SerializeField]
	private bool _cameraTest;
	[SerializeField]
	private int _renderTextureSize;
	[SerializeField]
	private float _cascadeBlendRange;
	[SerializeField]
	private float _range;
	[SerializeField]
	private float _receiverPlaneDepthBias;
	[SerializeField]
	private float _distanceBias;
	[SerializeField]
	private float _padOffset;
	[SerializeField]
	private float _padExponent;
	[SerializeField]
	private Light _light;
	[SerializeField]
	private RingworldShadowsOverride _ringworldShadowsOverride;
	[SerializeField]
	private int _debugFrustumDraw;
}
