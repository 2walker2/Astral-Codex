using System;
using UnityEngine;

namespace Tessellation
{
	[Serializable]
	public class MeshGroup : ScriptableObject
	{
		public Mesh[] variants;
	}
}
