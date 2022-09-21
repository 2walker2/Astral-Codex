using System;
using UnityEngine;

[Serializable]
public class StreamingTextureLookup : ScriptableObject
{
	[SerializeField]
	public Texture[] textures;
}
