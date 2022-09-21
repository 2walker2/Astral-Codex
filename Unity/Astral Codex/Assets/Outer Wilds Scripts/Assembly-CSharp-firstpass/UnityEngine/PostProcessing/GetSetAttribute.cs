using UnityEngine;

namespace UnityEngine.PostProcessing
{
	public class GetSetAttribute : PropertyAttribute
	{
		public GetSetAttribute(string name)
		{
		}

		public bool dirty;
	}
}
