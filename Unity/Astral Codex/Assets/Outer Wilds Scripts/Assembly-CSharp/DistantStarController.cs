using UnityEngine;
using System;

public class DistantStarController : MonoBehaviour
{
	[Serializable]
	private class ExplosionCurve
	{
		private ExplosionCurve()
		{
		}

		public AnimationCurve explosionsByTime;
	}

	[SerializeField]
	private float _starsUpdateIntervalInSeconds;
	[SerializeField]
	private GameObject _starExplosionObject;
	[SerializeField]
	private ExplosionCurve StarFieldExplosionCurve;
}
