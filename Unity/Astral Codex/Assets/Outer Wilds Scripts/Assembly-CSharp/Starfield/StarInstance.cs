using System;
using UnityEngine;

namespace Starfield
{
	[Serializable]
	public struct StarInstance
	{
		public Vector3 position;
		public float scale;
		public Color color;
		public float brightness;
		public bool supernova;
		public float deathStartTime;
		public float deathLength;
	}
}
