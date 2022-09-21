using System;

namespace Steamworks
{
	[Serializable]
	public class gameserveritem_t
	{
		public servernetadr_t m_NetAdr;
		public int m_nPing;
		public bool m_bHadSuccessfulResponse;
		public bool m_bDoNotRefresh;
		public uint m_nAppID;
		public int m_nPlayers;
		public int m_nMaxPlayers;
		public int m_nBotPlayers;
		public bool m_bPassword;
		public bool m_bSecure;
		public uint m_ulTimeLastPlayed;
		public int m_nServerVersion;
		public CSteamID m_steamID;
	}
}
