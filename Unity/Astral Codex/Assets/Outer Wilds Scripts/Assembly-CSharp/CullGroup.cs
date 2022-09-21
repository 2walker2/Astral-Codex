using UnityEngine;
using System;
using System.Collections.Generic;

public class CullGroup : MonoBehaviour
{
	[Serializable]
	public struct ParticleSystemPair
	{
		public ParticleSystemPair(Renderer r, ParticleSystem ps) : this()
		{
		}

		public Renderer renderer;
		public ParticleSystem particleSystem;
	}

	public enum ParticleSystemSuspendMode
	{
		None = 0,
		Pause = 1,
		Stop = 2,
	}

	[SerializeField]
	private bool _prebuilt;
	[SerializeField]
	private List<Renderer> _staticRenderers;
	[SerializeField]
	private List<OWRenderer> _dynamicRenderers;
	[SerializeField]
	private List<CullGroup.ParticleSystemPair> _particleSystems;
	[SerializeField]
	private List<StreamingRenderMeshHandle> _streamingMeshes;
	[SerializeField]
	private List<LODGroup> _lodGroups;
	[SerializeField]
	private SphereBounds _dynamicSphereBounds;
	[SerializeField]
	private SphereBounds _finalSphereBounds;
	[SerializeField]
	private Vector3 _localStaticBoundsCenter;
	[SerializeField]
	private SphereBounds _staticSphereBounds;
	[SerializeField]
	private bool _crossfade;
	[SerializeField]
	private float _crossfadeLength;
	[SerializeField]
	private bool _occlusionCulling;
	[SerializeField]
	private bool _dynamicCullingBounds;
	[SerializeField]
	private ParticleSystemSuspendMode _particleSystemSuspendMode;
	[SerializeField]
	private bool _waitForStreaming;
}
