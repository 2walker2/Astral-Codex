using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class MeteorImpactRecord : ScriptableObject
{
	public List<FragmentData> fragmentData;
}
