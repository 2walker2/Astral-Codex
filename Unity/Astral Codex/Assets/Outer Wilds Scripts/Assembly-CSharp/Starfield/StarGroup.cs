using System;

namespace Starfield
{
	[Serializable]
	public class StarGroup
	{
		public StarInstance[] stars;
		public string name;
		public bool hidden;
	}
}
