using UnityEngine;

public class DistanceCullGroup : CullGroup
{
	[SerializeField]
	private int _minLevel;
	[SerializeField]
	private int _maxLevel;
}
