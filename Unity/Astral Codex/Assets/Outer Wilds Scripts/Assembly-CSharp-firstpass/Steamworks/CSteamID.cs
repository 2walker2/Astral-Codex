using System;

namespace Steamworks
{
	[Serializable]
	public struct CSteamID
	{
		public CSteamID(ulong ulSteamID) : this()
		{
		}

		public ulong m_SteamID;
	}
}
