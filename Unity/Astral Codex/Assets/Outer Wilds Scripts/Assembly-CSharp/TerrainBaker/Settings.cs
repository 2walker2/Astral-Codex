using System;

namespace TerrainBaker
{
	[Serializable]
	public struct Settings
	{
		public bool exportNormals;
		public bool exportTangents;
		public bool exportColors;
		public ChannelData uv0Data;
		public ChannelData uv1Data;
		public ChannelData uv2Data;
		public ChannelData uv3Data;
		public UVProjector uv0Projector;
		public UVProjector uv1Projector;
		public UVProjector uv2Projector;
		public UVProjector uv3Projector;
	}
}
