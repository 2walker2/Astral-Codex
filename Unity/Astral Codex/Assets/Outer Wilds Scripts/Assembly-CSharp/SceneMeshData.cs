using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class SceneMeshData : ScriptableObject
{
	[SerializeField]
	public List<Mesh> data;
}
