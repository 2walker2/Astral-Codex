using System;
using UnityEngine;

public class AnimationEventEffect : SectoredMonoBehaviour
{
	[Serializable]
	public struct PrefabTransform
	{
		public GameObject prefab;
		public Transform targetTransform;
	}

	[Serializable]
	public struct EventActivations
	{
		[SerializeField]
		public AnimationEventEffect.PrefabTransform[] prefabs;
		public ParticleSystem[] ParticleSystems;
		public OWAudioSource audioSource;
		public float audioDelay;
	}

	[SerializeField]
	private EventActivations[] _eventActivations;
}
