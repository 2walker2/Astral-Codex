using System;
using System.Collections.Generic;

public class CreditsData
{
	[Serializable]
	public class CreditsLine
	{
		public string m_style;
		public float m_yOffset;
		public string m_string;
	}

	[Serializable]
	public class CreditsPage
	{
		public enum YAlign
		{
			TOP = 0,
			MIDDLE = 1,
			BOTTOM = 2,
		}

		public YAlign m_yAlign;
		public List<CreditsData.CreditsLine> m_lines;
		public float m_scrollSpeed;
		public float m_scrollDuration;
		public float m_displayTime;
		public float m_waitTime;
	}

}
