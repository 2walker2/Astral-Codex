using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializedDictionary<K, V> : Dictionary<K, V>
{
	[SerializeField]
	private List<K> m_Keys;
	[SerializeField]
	private List<V> m_Values;
}
