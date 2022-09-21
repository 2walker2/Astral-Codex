using UnityEngine;

public class MultiStateQuantumObject : QuantumObject
{
	[SerializeField]
	private QuantumState[] _states;
	[SerializeField]
	private int _initialState;
	[SerializeField]
	private bool _sequential;
	[SerializeField]
	private bool _loop;
	[SerializeField]
	private bool _reverse;
	[SerializeField]
	private MultiStateQuantumObject[] _prerequisiteObjects;
	[SerializeField]
	private GameObject _prerequisiteRoot;
}
