using UnityEngine;

namespace TerrainBaker
{
	public class UVProjectorConical : UVProjector
	{
		[SerializeField]
		protected float _bottomHeight;
		[SerializeField]
		protected float _topHeight;
		[SerializeField]
		protected float _arc;
	}
}
