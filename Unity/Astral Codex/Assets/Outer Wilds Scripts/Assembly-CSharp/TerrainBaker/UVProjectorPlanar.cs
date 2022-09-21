using UnityEngine;

namespace TerrainBaker
{
	public class UVProjectorPlanar : UVProjector
	{
		public enum Plane
		{
			X = 0,
			Y = 1,
			Z = 2,
		}

		[SerializeField]
		protected Plane _plane;
		[SerializeField]
		protected Vector2 _scale;
	}
}
