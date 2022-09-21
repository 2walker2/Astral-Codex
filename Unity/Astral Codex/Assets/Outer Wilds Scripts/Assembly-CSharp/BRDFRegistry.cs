using System;
using UnityEngine;

[Serializable]
public class BRDFRegistry : ScriptableObject
{
	public Color[] brdfSpecColors;
	public Texture2D[] brdfLookups;
	public Texture2DArray brdfLookupArray;
}
